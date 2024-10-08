namespace FluentValidationApp.Web.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string EPosta { get; set; }
        public int Yas { get; set; }
        public string FullName { get; set; }

        public string Number { get; set; }
        public string ValidDate { get; set; }

    }
}
