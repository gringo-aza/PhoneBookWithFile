namespace PhoneBookWithFile.Services
{
    internal interface IFileService
    {
        public string AddContact(string name, string phoneNumber);
        public void ReadAllContact();
        public void DeleteContactByName(string name);

    }
}