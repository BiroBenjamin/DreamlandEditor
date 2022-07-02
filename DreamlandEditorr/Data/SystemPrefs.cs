namespace DreamlandEditor.Data {
    //[Serializable()]
    public class SystemPrefs /*: ISerializable*/ {
        public string rootPath = @"C:\Temp";
        public bool isDevMode = false;

        public SystemPrefs() {
        }
        /*public SystemPrefs(SerializationInfo info, StreamingContext context) {
            rootPath = info.GetString("static.rootPath");
            isDevMode = info.GetBoolean("static.isDevMode");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("static.rootPath", rootPath, typeof(string));
            info.AddValue("static.isDevMode", isDevMode, typeof(bool));
        }*/
        public override string ToString() {
            return $"[ rootPath: {rootPath} ]" +
                $"  [ isDevMode: {isDevMode} ]";
        }

    }
}
