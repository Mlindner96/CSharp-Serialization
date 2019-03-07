//*******************************************************************************
// File: Student.cs
//
// Purpose: Contains class definition for Student.
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
    public class Student
    {
        #region member variables
        private string name, id, major;
        #endregion

        //********************************************************************
        // Method: Student default constructor
        //
        // Purpose: To initialize member variables.
        //********************************************************************
        public Student()
        {
            name = " ";
            id = " ";
            major = " ";
        }
        #region C# Properties
        //********************************************************************
        // Method: GetName
        //
        // Purpose: To shadow and access name member variable.
        //********************************************************************
        public string GetName
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        //********************************************************************
        // Method: GetId
        //
        // Purpose: To shadow and access id member variable.
        //********************************************************************
        public string GetId
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        //********************************************************************
        // Method: GetMajor
        //
        // Purpose: To shadow and access major member variable.
        //********************************************************************
        public string GetMajor
        {
            get
            {
                return major;
            }

            set
            {
                major = value;
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
            return "Name: " + name + "\n" + "ID: " + id + "\n" +
                   "Major: " + major + "\n";
        }

        private Student s;

        //********************************************************************
        // Method:  OpenJSON
        //
        // Purpose: Read Student member variables from a JSON file
        //********************************************************************
        public Student OpenJSON(string filename)
        {
            FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read);

            DataContractJsonSerializer inputSerializer;
            inputSerializer = new DataContractJsonSerializer(typeof(Student));
            s = (Student)inputSerializer.ReadObject(reader);
            reader.Close();
            return s;
        }

        //********************************************************************
        // Method: OpenXML
        //
        // Purpose: Read Student member variables from XML file.
        //********************************************************************
        public Student OpenXML(string filename)
        {
            FileStream reader = new FileStream(filename, FileMode.Open, FileAccess.Read);

            DataContractSerializer inputSerializer;
            inputSerializer = new DataContractSerializer(typeof(Student));
            s = (Student)inputSerializer.ReadObject(reader);
            reader.Close();
            return s;
        }

        //********************************************************************
        // Method: SaveJSON
        //
        // Purpose: Write Student member variables to JSON file.
        //********************************************************************
        public Student SaveJSON(string filename)
        {
           FileStream writer = new FileStream(filename, FileMode.Create,
           FileAccess.Write);

           DataContractJsonSerializer ser;
           ser = new DataContractJsonSerializer(typeof(Student));

           ser.WriteObject(writer, s);
           writer.Close();
            return s;
        }

        //********************************************************************
        // Method: SaveXML
        //
        // Purpose: Write Student member variables to an XML file.
        //********************************************************************
        public Student SaveXML(string filename)
        {
            FileStream writer = new FileStream(filename, FileMode.Create,
            FileAccess.Write);

            DataContractSerializer ser;
            ser = new DataContractSerializer(typeof(Student));

            ser.WriteObject(writer, s);
            writer.Close();
            return s;
        }

        //********************************************************************
        // Method:  Show
        //
        // Purpose: To display Student member variables on the console.
        //********************************************************************
        public void Show()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(major);
        }
        #endregion

        #region Serialization
        [DataMember(Name = "name")]
        public string SName { get { return name; } set { name = value; } }

        [DataMember(Name = "id")]
        public string SId { get { return id; } set { id = value; } }

        [DataMember(Name = "major")]
        public string SMajor { get { return major; } set { major = value; } }
        #endregion
    }
}
