namespace encryption
{
    public class encryption_method
    {
        string name { get; set; }
        string key { get; set; }

        public encryption_method(string name, string key)
        {
            this.name = name;
            this.key = key;
        }

        public string execute_encryption_method(string text)
        {
            if (name == "XOR")
            {
                string result = "";
                for (int i = 0; i < text.Length; i++)
                {
                    result += (char)(text[i] ^ key[i % key.Length]);
                }
                return result;
            }
            else
            {
                return "Error: No encryption method found";
            }
        }

        public string execute_decryption_method(string text)
        {
            if (name == "XOR")
            {
                string result = "";
                for (int i = 0; i < text.Length; i++)
                {
                    result += (char)(text[i] ^ key[i % key.Length]);
                }
                return result;
            }
            else
            {
                return "Error: No encryption method found";
            }
        }
    }
}