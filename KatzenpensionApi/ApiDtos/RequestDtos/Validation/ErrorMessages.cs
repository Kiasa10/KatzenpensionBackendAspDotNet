namespace KatzenpensionApi.ApiDtos.RequestDtos.Validation
{
    public class ErrorMessages
    {
        public const string TextboxLength = "Ihre Eingabe muss zwischen 3 und max. 500 Zeichen lang sein.";
        public const string TextRequired = "Ihre Eingaben müssen Text enthalten. Bitte versuchen Sie es nochmal.";
        public const string TextLength = "Ihre Eingabe muss zwischen 3 und max. 50 Zeichen lang sein.";
        public const string ShortTextLength = "Eingabe muss zwischen 1 und 10 Zeichen lang sein.";
        public const string RequiredField = "Dies ist ein Pflichtfeld.";
        public const string ValidEmail = "Bitte geben Sie eine gültige E-Mail Adresse an.";
    }
}
