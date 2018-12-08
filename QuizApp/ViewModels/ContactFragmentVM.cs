namespace QuizApp
{
    public class ContactFragmentVM: BaseViewModel
    {
        public string Street { get; set; }
        public string PostalNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
        public ContactFragmentVM()
        {
            getInfo();
        }
        private void getInfo()
        {
            Street = "360 King Street";
            PostalNumber = "Feasterville, Trevose PA 19053";
            PhoneNumber = "(800) 900-200-300";
            Email = "info@gmail.com";
        }
    }
}
