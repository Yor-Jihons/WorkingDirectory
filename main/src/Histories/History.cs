namespace WorkingDirectory.Histories
{
    [System.Xml.Serialization.XmlRoot("history")]
    public class History
    {
        public static History Load(string filepath)
        {
            if (filepath.Equals(string.Empty) || !System.IO.File.Exists(filepath))
            {
                return new History(){ Paths = [] };
            }

            var fs = new System.IO.FileStream(filepath, System.IO.FileMode.Open);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(History));
            var res = (History)serializer.Deserialize(fs);
            fs.Close();
            return res;
        }

        public static void Save(History history, string filepath)
        {
            var fs = new System.IO.FileStream(filepath, System.IO.FileMode.Create);
            var serializer = new System.Xml.Serialization.XmlSerializer(history.GetType());
            serializer.Serialize(fs, history);
            fs.Close();
        }

        [System.Xml.Serialization.XmlElement("paths")]
        public System.Collections.Generic.List<string> Paths{ get; set; }
    }
}
