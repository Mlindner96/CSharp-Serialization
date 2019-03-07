//*******************************************************************************
// File: TranscriptUnitTesting.cs
//
// Purpose: Contains class definition for TranscriptUnitTesting.
//
// Written By: Mike Lindner
//
// Compiler: Visual Studio 2017
//
//*******************************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TranscriptUnitTesting
    {
        #region unitTestingCourse
        //********************************************************************
        // Method: UnitTestCourse
        //
        // Purpose: To conduct automated testing of member variables of the
        //          Course class.
        //********************************************************************
        public void UnitTestCourse()
        {
            Console.WriteLine("*********************\n");
            Console.WriteLine("Unit Testing: Course\n");
            Console.WriteLine("*********************\n");
            Course c = new Course();
            String testSubject = "English";
            c.GetSubject = testSubject;
            if (testSubject == c.GetSubject)
            {
                Console.WriteLine("Course Subject Property, Valid Value: Pass\n");
            }
            else
            {
                Console.WriteLine( "Course Subject Property, Valid Value: FAIL!\n");
            }

            String testNumber = "four";
            c.GetNumber = testNumber;
            if (testNumber == c.GetNumber)
            {
                Console.WriteLine("Course Number Property, Valid Value: Pass\n");
            }
            else
            {
                Console.WriteLine("Course Number Property, Valid Value: FAIL!\n");
            }

            String testTitle = "Intro to Programming";
            c.GetTitle = testTitle;
            if (testTitle == c.GetTitle)
            {
                Console.WriteLine("Course Title Property, Valid Value: Pass\n");
            }
            else
            {
                Console.WriteLine("Course Title Property, Valid Value: FAIL!\n");
            }

            String testDescription = "Basic Programming Concepts";
            c.GetDescription = testDescription;
            if (testDescription == c.GetDescription)
            {
                Console.WriteLine("Course Description Property, Valid Value: Pass\n");
            }
            else
            {
                Console.WriteLine("Course Description Property, Valid Value: FAIL!\n");
            }

            int testCredits = 3;
            c.GetCredits = testCredits;
            if (testCredits == c.GetCredits)
            {
                Console.WriteLine("Course Credits Property, Valid Value: Pass\n");
            }
            else
            {
                Console.WriteLine("Course Credits Property, Valid Value: FAIL!\n");
            }

            int invalidCredits = -77;
            c.GetCredits = invalidCredits;
            if (testCredits == c.GetCredits)
            {
                Console.WriteLine( "Course Credits Property, Invalid Value: Pass\n");
            }
            else
            {
                Console.WriteLine( "Course Credits Property, Invalid Value: FAIL!\n");
            }

            Console.ReadKey();
            
        }
        #endregion

        #region unitTestingStudent
        //********************************************************************
        // Method: UnitTestStudent
        //
        // Purpose: To conduct automated testing of member variables of the
        //          Student class.
        //********************************************************************
        public void UnitTestStudent()
        {
            Console.WriteLine("*********************\n");
            Console.WriteLine("Unit Testing: Student\n");
            Console.WriteLine("*********************\n");
            Student s = new Student();

            String testName = "Mike";
            s.GetName = testName;
            if (testName == s.GetName)
            {
                Console.WriteLine("Student Name Property, Valid Value: Pass\n");
            }
            else
            {
                Console.WriteLine("Student Name Property, Valid Value: FAIL!\n");
            }

            String testId = "three";
            s.GetId = testId;
            if (testId == s.GetId)
            {
                Console.WriteLine("Student Id Property, Valid Value: Pass\n");
            }
            else
            {
                Console.WriteLine("Student Id Property, Valid Value: FAIL!\n");
            }

            String testMajor = "Computer Programming";
            s.GetMajor = testMajor;
            if (testMajor == s.GetMajor)
            {
                Console.WriteLine("Student Major Property, Valid Value: Pass\n");
            }
            else
            {
                Console.WriteLine("Student Major Property, Valid Value: FAIL!\n");
            }

            Console.ReadKey();
        }
        #endregion
    }
}
