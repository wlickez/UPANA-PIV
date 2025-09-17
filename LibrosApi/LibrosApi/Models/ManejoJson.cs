namespace LibrosApi.Models
{
    public class ManejoJson
    {
        public List<Libro> ObtenerLibros()
        {
            try
            {
                FileInfo fileInfo = new FileInfo("Libros.json");
                var fileStream = fileInfo.OpenRead();

                using (fileStream)
                {
                    StreamReader streamReader = new(fileStream);
                    var st = streamReader.ReadToEnd();

                    List<Libro> libros = System.Text.Json.JsonSerializer.Deserialize<List<Libro>>(st);

                    return libros;
                }
            }
            catch (Exception)
            {
                return new List<Libro>();
            }
        }
        public bool AgregarLibro(Libro libro)
        {
            try
            {
                List<Libro> librosAntes = ObtenerLibros();

                librosAntes.Add(libro);

                FileInfo fi = new FileInfo("Libros.json");
                using (FileStream fs = fi.Create())
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(System.Text.Json.JsonSerializer.Serialize(librosAntes));
                    }
                }
                return true;
            }
            
            catch (Exception)
            {
                return false;
            }
        }
    }
}
