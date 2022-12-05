namespace Shortcuts
{

    public class BetterDemo : Demo
    {

        

        public BetterDemo(string firstName, string lasttName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new System.ArgumentException($"\"{nameof(firstName)}\" darf nicht NULL oder ein Leerraumzeichen sein.", nameof(firstName));
            }

            if (string.IsNullOrWhiteSpace(lasttName))
            {
                throw new System.ArgumentException($"\"{nameof(lasttName)}\" darf nicht NULL oder ein Leerraumzeichen sein.", nameof(lasttName));
            }

            FirstName = firstName;
            LasttName = lasttName;
        }

        public string FirstName { get; set; }

        public string LasttName { get; set; }

       
    }
}
