using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace archNoEstr
{
    public partial class Form1 : Form
    {
        // Variable para almacenar la ruta del archivo actualmente abierto
        private string rutaArchivoActual = string.Empty;

        public Form1()
        {
            InitializeComponent();
            ConfigurarListView();
        }

        /// <summary>
        /// Configura las propiedades iniciales del ListView
        /// </summary>
        private void ConfigurarListView()
        {
            listViewArchivo.View = View.Details;
            listViewArchivo.FullRowSelect = true;
            listViewArchivo.GridLines = true;
            listViewArchivo.MultiSelect = false;
            
            // Configurar columnas
            listViewArchivo.Columns.Clear();
            listViewArchivo.Columns.Add("Índice/Línea", 100);
            listViewArchivo.Columns.Add("Contenido", 600);
        }

        /// <summary>
        /// Botón 1: Abrir archivo .srt, .sql o .log
        /// </summary>
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos soportados|*.srt;*.log|Archivos SRT|*.srt|Archivos LOG|*.log|Todos los archivos|*.*";
                    openFileDialog.Title = "Seleccionar archivo";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        rutaArchivoActual = openFileDialog.FileName;
                        CargarArchivo(rutaArchivoActual);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos para acceder a este archivo.", "Error de Acceso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo no existe.", "Archivo No Encontrado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el archivo: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga el contenido del archivo en el ListView
        /// </summary>
        private void CargarArchivo(string rutaArchivo)
        {
            try
            {
                listViewArchivo.Items.Clear();
                string[] lineas = File.ReadAllLines(rutaArchivo);
                
                for (int i = 0; i < lineas.Length; i++)
                {
                    ListViewItem item = new ListViewItem((i + 1).ToString());
                    item.SubItems.Add(lineas[i]);
                    listViewArchivo.Items.Add(item);
                }

                this.Text = $"Gestor de Archivos - {Path.GetFileName(rutaArchivo)}";
                MessageBox.Show($"Archivo cargado exitosamente. {lineas.Length} líneas.", "Éxito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón 2: Modificar la línea seleccionada
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewArchivo.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una línea del ListView para modificar.", "Advertencia", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtContenido.Text))
                {
                    MessageBox.Show("El contenido no puede estar vacío.", "Advertencia", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListViewItem itemSeleccionado = listViewArchivo.SelectedItems[0];
                itemSeleccionado.SubItems[1].Text = txtContenido.Text;
                
                MessageBox.Show("Línea modificada exitosamente.", "Éxito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón 3: Agregar una nueva línea al final
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtContenido.Text))
                {
                    MessageBox.Show("Debe ingresar contenido para agregar.", "Advertencia", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nuevoIndice = listViewArchivo.Items.Count + 1;
                ListViewItem nuevoItem = new ListViewItem(nuevoIndice.ToString());
                nuevoItem.SubItems.Add(txtContenido.Text);
                listViewArchivo.Items.Add(nuevoItem);

                txtContenido.Clear();
                MessageBox.Show("Línea agregada exitosamente.", "Éxito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón 4: Eliminar la línea seleccionada
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewArchivo.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una línea para eliminar.", "Advertencia", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta línea?", 
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    listViewArchivo.Items.Remove(listViewArchivo.SelectedItems[0]);
                    ReindexarLineas();
                    MessageBox.Show("Línea eliminada exitosamente.", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reindexar todas las líneas después de una eliminación
        /// </summary>
        private void ReindexarLineas()
        {
            for (int i = 0; i < listViewArchivo.Items.Count; i++)
            {
                listViewArchivo.Items[i].Text = (i + 1).ToString();
            }
        }

        /// <summary>
        /// Botón 5: Guardar el archivo
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewArchivo.Items.Count == 0)
                {
                    MessageBox.Show("No hay contenido para guardar.", "Advertencia", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos SRT|*.srt|Archivos LOG|*.log|Todos los archivos|*.*";
                    saveFileDialog.Title = "Guardar archivo";
                    
                    if (!string.IsNullOrEmpty(rutaArchivoActual))
                    {
                        saveFileDialog.FileName = Path.GetFileName(rutaArchivoActual);
                    }

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        GuardarArchivo(saveFileDialog.FileName);
                        rutaArchivoActual = saveFileDialog.FileName;
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos para guardar en esta ubicación.", "Error de Acceso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Guarda el contenido del ListView en un archivo
        /// </summary>
        private void GuardarArchivo(string rutaArchivo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
                {
                    foreach (ListViewItem item in listViewArchivo.Items)
                    {
                        writer.WriteLine(item.SubItems[1].Text);
                    }
                }

                MessageBox.Show("Archivo guardado exitosamente.", "Éxito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón 6: Buscar contenido en el ListView
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    MessageBox.Show("Debe ingresar un texto para buscar.", "Advertencia", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string textoBuscar = txtBuscar.Text.ToLower();
                bool encontrado = false;

                foreach (ListViewItem item in listViewArchivo.Items)
                {
                    if (item.SubItems[1].Text.ToLower().Contains(textoBuscar))
                    {
                        item.Selected = true;
                        item.EnsureVisible();
                        item.BackColor = System.Drawing.Color.Yellow;
                        encontrado = true;
                    }
                    else
                    {
                        item.BackColor = System.Drawing.Color.White;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("No se encontraron coincidencias.", "Búsqueda", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón 7: Exportar a formato de texto plano
        /// </summary>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewArchivo.Items.Count == 0)
                {
                    MessageBox.Show("No hay contenido para exportar.", "Advertencia", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
                    saveFileDialog.Title = "Exportar a texto plano";
                    saveFileDialog.FileName = "exportacion.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false))
                        {
                            foreach (ListViewItem item in listViewArchivo.Items)
                            {
                                writer.WriteLine(item.SubItems[1].Text);
                            }
                        }

                        MessageBox.Show("Archivo exportado exitosamente.", "Éxito", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Botón 8: Importar y anexar contenido de otro archivo
        /// </summary>
        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Todos los archivos soportados|*.srt;*.log;*.txt|Archivos SRT|*.srt|Archivos LOG|*.log|Archivos TXT|*.txt|Todos los archivos|*.*";
                    openFileDialog.Title = "Importar archivo";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string[] lineas = File.ReadAllLines(openFileDialog.FileName);
                        int indiceInicial = listViewArchivo.Items.Count + 1;

                        foreach (string linea in lineas)
                        {
                            ListViewItem item = new ListViewItem(indiceInicial.ToString());
                            item.SubItems.Add(linea);
                            listViewArchivo.Items.Add(item);
                            indiceInicial++;
                        }

                        MessageBox.Show($"{lineas.Length} líneas importadas exitosamente.", "Éxito", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permisos para acceder a este archivo.", "Error de Acceso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo no existe.", "Archivo No Encontrado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al importar: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento al seleccionar un elemento del ListView
        /// Carga el contenido en el TextBox para facilitar la edición
        /// </summary>
        private void listViewArchivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewArchivo.SelectedItems.Count > 0)
                {
                    txtContenido.Text = listViewArchivo.SelectedItems[0].SubItems[1].Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar contenido: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
