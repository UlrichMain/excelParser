using Candidate;

namespace excelParser {

    Candidate[] candidates;
    Candidate temp = new Candidate();

    public void getClients()
    {
        string path = "C:\Users\USER\Downloads\ExcelParser.csv";
        StreamReader strRead = null;
        if (File.exists(path))
        {
            strRead = new SreamReader(File.openRead(path));
            List<string> clientVals = new List<string>();
            var headers = strRead.ReadLine();
            while (!strRead.EndOfStream)
            {
                var cLine = strRead.ReadLine();
                var cVals = cLine.Split(',');
                long cID = cVals[0];
                string pictureString = cVals[1];
                string name = cVals[2];
                string surname = cVals[3];
                int gender = cVals[4];
                string race = cVals[5];
                string university = cVals[6];
                string degree = cVals[7];
                string comments = cVals[8];
                string jobTitle = cVals[9];
            }

        }



    }


}