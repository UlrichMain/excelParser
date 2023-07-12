
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace excelParser{

    class Parser
    {

        static Candidate[] makeCandidatesList(string path)
        {
            /// <summary>
            /// path variable must be the entire path to the file and must include the filename and extension
            /// </summary>
            Candidate[] candidates = { };

            StreamReader strRead = null;
            if (File.Exists(path))
            {
                strRead = new StreamReader(File.OpenRead(path));
                var headers = strRead.ReadLine();

                string name;
                string surname;
                Gender gender;
                Race race;
                string university;
                string location;
                string degree;
                string comments;
                string jobTitle;
                int line = 0;

                while (!strRead.EndOfStream)
                {
                    String cNewLine = strRead.ReadLine();
                    String cLine = cNewLine.Substring(1, cNewLine.Length - 2);
                    String[] cVals = cLine.Split(';');

                    int cID = int.Parse(cVals[0]);
                    string pictureString = cVals[1];

                    if (cVals[2].Contains(" and "))
                    {
                        string full = cVals[2];
                        var nVals = full.Split(" and ");
                        name = nVals[0];
                        surname = nVals[1];
                        location = cVals[3];
                        gender = (Gender)Enum.Parse(typeof(Gender), cVals[4]);
                        race = (Race)Enum.Parse(typeof(Race), cVals[5]);
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
                        string full = cVals[2];
                        var nVals = full.Split(',');
                        name = nVals[0];
                        surname = nVals[1];
                        location = cVals[3];
                        gender = (Gender)Enum.Parse(typeof(Gender), cVals[4]);
                        race = (Race)Enum.Parse(typeof(Race), cVals[5]);
                        university = cVals[6];
                        degree = cVals[7];
                        comments = " ";
                        for (int i = 8; i < cVals.Length - 1; i++)
                        {
                            comments = comments + cVals[i];
                        }
                    
                    }

                    jobTitle = cVals[cVals.Length - 1];


                    Journey tempJourn = new Journey(Status.Prospective, gender, OpenDay.Scheduled, comments, new DateTime(2023, 10, 07));

                    Candidate temp = new Candidate(cID, pictureString, name, surname, location, gender, race, university, degree, comments, jobTitle, tempJourn);
                    temp.printCandidate();
                    if (ErrorChecker.isValidCandidate(temp))
                    {
                        candidates.Append(temp);
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Invalid data entry on line {0}. Returned list is incomplete", line.ToString()));
                        break;
                    }
                    line++;
                }
            }
            Console.ReadLine();
            return candidates;
        }

        static void Main(string[] args)
        {
            Candidate[] candidates = makeCandidatesList("C:\\Users\\USER\\Downloads\\ExcelParser(1).csv");
        }
    }

    class ErrorChecker
    {
        static string[] allowedJobs = { "software engineer", "ux engineer", "business analyst" }; //must all be lower case

        public static Boolean isValidCandidate(Candidate candidate)
        {
            string error = "";
            if (!hasValidValues(candidate))
                return false;

            if (!isValidNumber(candidate.getNum()))
                return false;

            if (!isValidPicture(candidate.getPictureString()))
                return false;

            if (!isValidName(candidate.getName()))
                return false;

            if (!isValidSurname(candidate.getSurname()))
                return false;

            if (!isValidLocation(candidate.getLocation()))
                return false;

            if (!isValidGender(candidate.getGender()))
                return false;

            if (!isValidUniversity(candidate.getUni()))
                return false;

            if (!isValidDegree(candidate.getDeg()))
                return false;

            if (!isValidComment(candidate.getComm()))
                return false;

            if (!isValidJobTitle(candidate.getJob()))
                return false;


            return true;
        }

        static Boolean hasValidValues(Candidate candidate)
        {
            /* Checks if every attribute but comments, univesity, degree and middlename are empty
             * If University is empty then degree can not be empty 
             */

            if (candidate.getNum() < 0)
                return false;

            if (candidate.getName() == "")
                return false;

            if (candidate.getSurname() == "")
                return false;

            if (candidate.getLocation() == "")
                return false;

            if (!Enum.IsDefined(typeof(Gender), candidate.getGender()))
                return false;

            if (!Enum.IsDefined(typeof(Race), candidate.getRace()))
                return false;

            if (candidate.getUni() != "" & candidate.getDeg() == "")
                return false;

            if (candidate.getJob() == "")
                return false;

            return true;
        }

        static Boolean isValidNumber(int number)
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

        static Boolean isValidGender(Gender gender)
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