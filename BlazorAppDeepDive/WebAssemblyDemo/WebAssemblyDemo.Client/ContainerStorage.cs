namespace WebAssemblyDemo.Client
{
    public class ContainerStorage
    {
        public string _message = string.Empty;
        public string GetMessage() { return _message; }
        public void SetMesssage(string message) { _message = message;  }
    }
}
