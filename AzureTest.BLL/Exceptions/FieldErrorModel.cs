namespace VetClinic.BLL.Exceptions
{
    public class FieldErrorModel
    {
        public string FieldName { get; set; }
        public string[] Messages { get; set; } = new string[] { };

        public FieldErrorModel() { }

        public FieldErrorModel(string fieldName, params string[] messages)
        {
            FieldName = fieldName;
            Messages = messages;
        }
    }
}