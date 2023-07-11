
using System.Reflection;

namespace excelParser{

    class Parser
    {
        static string[] allowedJobs = { "software engineer", "ux engineer", "business analyst" }; //must all be lower case
        static Candidate[] candidates;


        public void getCandidates()
        {
            string path = "C:\\Users\\USER\\Downloads\\ExcelParser.csv";
            StreamReader strRead = null;
            if (File.Exists(path))
            {
                strRead = new StreamReader(File.OpenRead(path));
                var headers = strRead.ReadLine();

                
                string name;
                string surname;
                string location;
                string gender;
                string race;
                string university;
                string degree;
                string comments;
                string jobTitle;

                while (!strRead.EndOfStream)
                {
                   

                    var cLine = strRead.ReadLine();
                    var cVals = cLine.Split(',');

                    string cID = cVals[0];
                    string pictureString = cVals[1];

                    if (cVals[2].Contains(" and "))
                    {
                        string full = cVals[2];
                        var nVals = full.Split(" and ");
                        name = nVals[0];
                        surname = nVals[1];
                        location = cVals[3];
                        gender = cVals[4];
                        race = cVals[5];
                        university = cVals[6];
                        degree = cVals[7];
                        comments = " ";
                        for (int i = 8; i < cVals.Length - 1; i++)
                        {
                            comments = comments + cVals[i];
                        }
                        
                    }

                    else
                    {
                        name = cVals[2];
                        surname = cVals[3];
                        location = cVals[4];
                        gender = cVals[5];
                        race = cVals[6];
                        university = cVals[7];
                        degree = cVals[8];
                        comments = " ";
                        for (int i = 9; i < cVals.Length - 1; i++)
                        {
                            comments = comments + cVals[i];
                        }
                    
                    }

                    jobTitle = cVals[cVals.Length - 1];
                    Candidate temp = new Candidate(cID, pictureString, name, surname, location, gender, race, university, degree, comments, jobTitle);

                }
            }
        }

        static void Main(string[] args)
        {
            Candidate candidate = new Candidate();
            candidate.number = 1;
            candidate.pictureString = "1232";
            candidate.name = "Jessica";
            candidate.surname = "Parker";
            candidate.location = "Sandton";
            candidate.gender = "Other";
            candidate.race = "White";
            candidate.university = "University of Johannesburg";
            candidate.degree = "Bsc in Computer Science";
            candidate.comments = "hard working mfer";
            candidate.jobTitle = "software Engineer";

            Console.Write(isValidCandidate(candidate));
        }

        /* Required Restrictions:
         * numbers
         * pictureString
         * name
         * surname
         * location
         * gender
         * race
         * university
         * degree
         * comments
         * jobTitle
         */

        static Boolean isValidCandidate(Candidate candidate)
        {

            if (!hasValidValues(candidate))
                return false;

            if (!isValidNumber(candidate.number))
                return false;

            if (!isValidPicture(candidate.pictureString))
                return false;

            if (!isValidName(candidate.name))
                return false;

            if (!isValidSurname(candidate.surname))
                return false;

            if (!isValidLocation(candidate.location))
                return false;

            if (!isValidGender(candidate.gender))
                return false;

            if (!isValidUniversity(candidate.university))
                return false;

            if (!isValidDegree(candidate.degree))
                return false;

            if (!isValidComment(candidate.comments))
                return false;

            if (!isValidJobTitle(candidate.jobTitle))
                return false;


            return true;
        }

        static Boolean hasNoNullValues(Candidate candidate)
        {
            /* Checks if every attribute but comments, univesity, degree and middlename are null
             * If University is null then degree can not be null.
             * This function is probably not needed, depending on Richard's implementation
             */

            if (candidate.number.ToString() == null)
                return false;

            if (candidate.pictureString == null)
                return false;

            if (candidate.name == null)
                return false;

            if (candidate.surname == null)
                return false;

            if (candidate.location == null)
                return false;

            if (candidate.gender == null)
                return false;

            if (candidate.race == null)
                return false;

            if (candidate.university != null && candidate.degree == null)
                return false;

            if (candidate.jobTitle == null)
                return false;

            return true;

        }

        static Boolean hasValidValues(Candidate candidate)
        {
            /* Checks if every attribute but comments, univesity, degree and middlename are empty
             * If University is empty then degree can not be empty 
             */

            if (candidate.number.ToString()=="")
                return false;

            if (candidate.pictureString == "")
                return false;

            if (candidate.name == "")
                return false;

            if (candidate.surname == "")
                return false;

            if (candidate.location == "")
                return false;

            if (candidate.gender == "")
                return false;

            if (candidate.race == "")
                return false;

            if (candidate.university != "" && candidate.degree=="")
                return false;

            if (candidate.jobTitle == "")
                return false;

            return true;
        }

        static Boolean isValidNumber(long? number)
        {
            return true;
        }

        static Boolean isValidPicture(string? picture)
        {
            return true;
        }

        static Boolean isValidName(string? name)
        {
            return true;
        }

        static Boolean isValidSurname(string? surname)
        {
            return true;
        }

        static Boolean isValidLocation(string? location)
        {
            return true;
        }

        static Boolean isValidGender(string? gender)
        {
            return true;
        }

        static Boolean isValidUniversity(string? university)
        {
            return true;
        }

        static Boolean isValidDegree(string? degree)
        {
            return true;
        }

        static Boolean isValidComment(string? comment)
        {
            return true;
        }

        static Boolean isValidJobTitle(string? job)
        {
            if (!allowedJobs.Contains(job.ToLower()))
                return false; 

            return true;
        }


    }



    


}