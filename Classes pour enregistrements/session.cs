using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Pieu_Pro.Classes_pour_enregistrements
{
    public class session
    {
        
        private const string FILENAME = "session.xml";

        private static string _applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string _applicationPath = Path.Combine(_applicationDataPath, "Pieu-Pro");

        private readonly XmlWriterSettings _writterSettings;

        public static string BackupPath = Path.Combine(_applicationDataPath, "Pieu-Pro", "backup");

        /// <summary>
        /// Chemin d'accés et nom du fichier représentant la session.
        /// </summary>
        public static string FileName { get; } = Path.Combine(_applicationPath, FILENAME);

        [XmlAttribute(AttributeName = "ActiveIndex")]
        public int ActiveIndex { get; set; } = 0;

        [XmlElement(ElementName = "File")]
        public List<pieuprofile> Files { get; set; }

        public session()
        {
            Files = new List<pieuprofile>();

            _writterSettings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = ("\t"),
                OmitXmlDeclaration = true
            };

            if (!Directory.Exists(_applicationPath))
            {
                Directory.CreateDirectory(_applicationPath);
            }
        }

        public static async Task<session> Load()
        {
            var session = new session();

            if (File.Exists(FileName))
            {
                var serializer = new XmlSerializer(typeof(session));
                var streamReader = new StreamReader(FileName);

                try
                {
                    session = (session)serializer.Deserialize(streamReader);

                    foreach (var file in session.Files)
                    {
                        var fileName = file.FileName;
                        var backupFileName = file.BackupFileName;

                        file.SafeFileName = Path.GetFileName(fileName);

                        // Fichier existant sur le disque.
                        if (File.Exists(fileName))
                        {
                            using (StreamReader reader = new StreamReader(fileName))
                            {
                                file.Contents = await reader.ReadToEndAsync();
                            }
                        }

                        // Fichier BACKUP du dossier BACKUP.
                        if (File.Exists(backupFileName))
                        {
                            using (StreamReader reader = new StreamReader(backupFileName))
                            {
                                file.Contents = await reader.ReadToEndAsync();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Une erreur s'est produite :" + ex.Message);
                }
                streamReader.Close();
            }

            return session;
        }

        public void Save(string FileName)
        {
            var emptyNamespace = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(typeof(session));

            using (XmlWriter writer = XmlWriter.Create(FileName, _writterSettings))
            {
                serializer.Serialize(writer, this, emptyNamespace);
            }
        }

        public async void BackupFile(pieuprofile file)
        {
            if (!Directory.Exists(BackupPath))
            {
                await Task.Run(() => Directory.CreateDirectory(BackupPath));
            }

            if (file.FileName.StartsWith("Sans titre"))
            {
                using (StreamWriter writer = File.CreateText(file.BackupFileName))
                {
                    await writer.WriteAsync(file.Contents);
                }
            }
        }
    }
}
