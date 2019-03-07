//*******************************************************************************
// File: Course.cs
//
// Purpose: Contains class definition for Course.
//
// Written By: Mike Lindner
//
// Compiler: Visual Studio 2017
//
//*******************************************************************************
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [DataContract]
    public class Course
    {
        #region member variables
        private string subject, number, title, description;
        private int credits;
        #endregion
        //********************************************************************
        // Method: Course default constructor
        //
        // Purpose: To initialize member variables.
        //********************************************************************
        public Course()
        {
            subject = " ";
            number = " ";
            title = " ";
            description = " ";
            credits = 0;
        }
        #region C#Properties
        //********************************************************************
        // Method: GetSubject
        //
        // Purpose: To shadow and access subject member variable.
        //********************************************************************
        public string GetSubject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

        //********************************************************************
        // Method: GetNumber
        //
        // Purpose: To shadow and access number member variable.
        //********************************************************************
        public string GetNumber
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        //********************************************************************
        // Method: GetTitle
        //
        // Purpose: To shadow and access title member variable.
        //********************************************************************
        public string GetTitle
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        //********************************************************************
        // Method: GetDescription
        //
        // Purpose: To shadow and access description member variable.
        //********************************************************************
        public string GetDescription
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        //********************************************************************
        // Method: GetCredits
        //
        // Purpose: To shadow and access credits member variable.
        //********************************************************************
        public int GetCredits
        {
            get
            {
                return credits;
            }

            set
            {
                if (credits >= 0 )
                {
                    credits = value;
                }
            }
        }
        #endregion

        #region Methods
        //********************************************************************
        // Method: ToString
        //
        // Purpose: To display member variables with descriptive text 
        //          in a string.
        //********************************************************************
        override
        public string ToString()
        {
            return "Subject: " + subject + "\n" + "Number: " + number + "\n" +
                    "Title: " + title + "\n" + "Description: " + description + 
                    "\n" + "Credits: " + credits + "\n";
        }

        private Course c;

        //********************************************************************
        // Method:  OpenJSON
        //
        // Purpose: Read Course member variables from a JSON file
        //********************************************************************
        public Course OpenJSON(string filename)
        {
            FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read);

            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(Course));
            c = (Course)inputSerializer.ReadObject(reader);
            reader.Close();
            return c;

        }

        //********************************************************************
        // Method: OpenXML
        //
        // Purpose: Read Course member variables from XML file.
        //********************************************************************
        public Course OpenXML(string filename)
        {
            FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read);

            DataContractSerializer inputSerializer;
            inputSerializer = new DataContractSerializer(typeof(Course));
            c = (Course)inputSerializer.ReadObject(reader);
            reader.Close();
            return c;
        }

        //********************************************************************
        // Method: SaveJSON
        //
        // Purpose: Write Course member variables to JSON file.
        //********************************************************************
        public Course SaveJSON(string filename)
        {
            FileStream writer = new FileStream(filename, FileMode.Create,
            FileAccess.Write);

            DataContractJsonSerializer ser;
            ser = new DataContractJsonSerializer(typeof(Course));

            ser.WriteObject(writer, c);
            writer.Close();
            return c;
        }

        //********************************************************************
        // Method: SaveXML
        //
        // Purpose: Write Course member variables to an XML file.
        //********************************************************************
        public Course SaveXML(string filename)
        {
            FileStream writer = new FileStream(filename, FileMode.Create,
            FileAccess.Write);

            DataContractSerializer ser;
            ser = new DataContractSerializer(typeof(Course));

            ser.WriteObject(writer, c);
            writer.Close();
            return c;
        }

        //********************************************************************
        // Method:  Show
        //
        // Purpose: To display Course member variables on the console.
        //********************************************************************
        public void Show()
        {
            Console.WriteLine(subject);
            Console.WriteLine(number);
            Console.WriteLine(title);
            Console.WriteLine(description);
            Console.WriteLine(credits);
        }
        #endregion

        #region Serialization
        [DataMember(Name = "subject")]
        public string SSubject { get { return subject; } set { subject = value; } }

        [DataMember(Name = "number")]
        public string SNumber { get { return number; } set { number = value; } }

        [DataMember(Name = "title")]
        public string STitle { get { return title; } set { title = value; } }

        [DataMember(Name = "description")]
        public string SDescription { get { return description; } set { description = value; } }

        [DataMember(Name = "id")]
        public int SCredits { get { return credits; } set { credits = value; } }
        #endregion
    }
}
