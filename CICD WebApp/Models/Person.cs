namespace CICD_WebApp.Models
{
    public class Person
    {
        FirstnameDTO firstName;
        LastnameDTO lastName;

        public Person(FirstnameDTO firstName, LastnameDTO lastName)
        {
            isFirstNameValid(firstName);
            isLastNameValid(lastName);

            this.firstName = firstName; 
            this.lastName = lastName;
        }

        private void isFirstNameValid(FirstnameDTO name)
        {
            ///Add Invariance validation Here
            /// Throw an Exception if the name is invalid
        }
        private void isLastNameValid(LastnameDTO name)
        {
            ///Add Invariance validation Here
            /// Throw an Exception if the name is invalid
        }
    }
}
