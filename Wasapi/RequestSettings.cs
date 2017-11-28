namespace Wasapi
{
    public class RequestSettings
    {
        public Language Language { get; set; }
        
        public ResultType ResultType { get; set; }
        
        public int Limit { get; set; }
        
        public PartOfSpeech[] PartsOfSpeech { get; set; }
        
        public bool Indent { get; set; }

        public RequestSettings()
        {
            Language = Language.En;
            ResultType = ResultType.Stimulus;
            Limit = 50;
            PartsOfSpeech = new[] {PartOfSpeech.Noun, PartOfSpeech.Adjective, PartOfSpeech.Verb, PartOfSpeech.Adverb};
            Indent = true;
        }

        public static RequestSettings Default => new RequestSettings();

        public string ToUrlString()
        {
            return $"lang={Language.ToString()}&type={ResultType}&limit={Limit}&pos={GetLanguages()}&indent={GetIndent()}".ToLower();
        }

        private string GetIndent()
        {
            return Indent ? "Yes" : "No";
        }

        private string GetLanguages()
        {
            return string.Join(",", PartsOfSpeech);
        }
    }
}