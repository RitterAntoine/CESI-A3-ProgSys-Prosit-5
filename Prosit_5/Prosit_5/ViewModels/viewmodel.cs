using encryption;

namespace Prosit_5
{
    class viewmodel
    {
        readonly view view = new view();
        readonly encryption_method encryption = new encryption_method("XOR", "key");

        public List<string> askusertext()
        {
            view.print("Please enter the text you want to encrypt:");
            string text = Console.ReadLine();

            view.print("Please enter the key you want to use:");
            string key = Console.ReadLine();

            string name = "XOR";

            return new List<string> { text, key, name };
        }

        public void displayresult(string text, string key, string name)
        {
            view.print("The encrypted text is:");
            string encrypted_text = encrypt(text, key, name);
            view.print(encrypted_text);

            view.print("The decrypted text is:");
            string decrypted_text = decrypt(encrypted_text, key, name);
            view.print(decrypted_text);
        }

        public string encrypt(string text, string key, string name)
        {
            encryption_method encryption_method = new encryption_method(name, key);
            return encryption_method.execute_encryption_method(text);
        }

        public string decrypt(string text, string key, string name)
        {
            encryption_method encryption_method = new encryption_method(name, key);
            return encryption_method.execute_decryption_method(text);
        }
    }
}