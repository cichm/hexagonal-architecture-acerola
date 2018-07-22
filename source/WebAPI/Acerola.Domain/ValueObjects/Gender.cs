namespace Acerola.Domain.ValueObjects
{
    public sealed class Gender
    {
        private string _text;

        private Gender()
        {
        }

        public Gender(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new NameShouldNotBeEmptyException("The 'Gender' field is required.");
            }

            _text = text;
        }

        public override string ToString() => _text.ToString();   
        public static implicit operator Gender(string text) => new Gender(text);
        public static implicit operator string(Gender gender) => gender._text;   
        
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is string)
            {
                return obj.ToString() == _text;
            }

            return ((Gender)obj)._text == _text;
        }

        public override int GetHashCode() => _text.GetHashCode();
    }
}
