//*******************************************************************************
// File: Transcript.cs
//
// Purpose: Contains class definition for Transcript.
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
    public class Transcript
    {
        private Student student;

        public Transcript()
        {
            student = new Student();
        }

        #region C# Properties
        //********************************************************************
        // Method: Student
        //
        // Purpose: To shadow and access student member variable.
        //********************************************************************
        public Student Student { get; set; }
        #endregion

        #region Methods
        //********************************************************************
        // Method: ToString
        //
        // Purpose: To display member variable with descriptive text
        //          in a string.
        //********************************************************************
        override
        public string ToString()
        {
            return "Name: " + student.GetName + "\n" + "ID: " + student.GetId + "\n" +
                   "Major: " + student.GetMajor + "\n";
        }
        private Transcript t;

        //********************************************************************
        // Method:  OpenJSON
        //
        // Purpose: Read Transcript member variables from a JSON file
        //********************************************************************
        public Transcript OpenJSON(string filename)
        {
            FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read);

            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(Transcript));

            t = (Transcript)inputSerializer.ReadObject(reader);
            reader.Close();
            return t;
        }

        //********************************************************************
        // Method: OpenXML
        //
        // Purpose: Read Transcript member variables from XML file.
        //********************************************************************
        public Transcript OpenXML(string filename)
        {
            FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read);

            DataContractSerializer inputSerializer;
            inputSerializer = new DataContractSerializer(typeof(Transcript));

            t = (Transcript)inputSerializer.ReadObject(reader);
            reader.Close();
            return t;
        }

        //********************************************************************
        // Method: SaveJSON
        //
        // Purpose: Write Transcript member variables to JSON file.
        //********************************************************************
        public Transcript SaveJSON(string filename)
        {
            FileStream writer = new FileStream(filename, FileMode.Create,
            FileAccess.Write);
            DataContractJsonSerializer ser;
            ser = new DataContractJsonSerializer(typeof(Transcript));
            ser.WriteObject(writer, t);
            writer.Close();
            return t;
        }

        //********************************************************************
        // Method: SaveXML
        //
        // Purpose: Write Transcript member variables to an XML file.
        //********************************************************************
        public Transcript SaveXML(string filename)
        {
            FileStream writer = new FileStream(filename, FileMode.Create,
            FileAccess.Write);
            DataContractSerializer ser;
            ser = new DataContractSerializer(typeof(Transcript));
            ser.WriteObject(writer, t);
            writer.Close();
            return t;
        }

        //********************************************************************
        // Method:  Show
        //
        // Purpose: To display Transcript member variables on the console.
        //********************************************************************
        public void Show()
        {
            Console.WriteLine(student);
        }
        #endregion


        #region Serialization

        [DataMember(Name = "student")]
        public Student SStudent { get { return student; } set { student = value; } }

        #endregion
    }
}