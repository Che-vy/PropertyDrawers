using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scheduler : MonoBehaviour
{
    public class Classnode
    {
        public char classLetter;
        public int[] timeSlot;

        public Classnode(char l, int[] ts)
        {
            classLetter = l;
            timeSlot = ts;
        }
    }

    void Start()
    {
        Classnode[] classNodes = {
            new Classnode('a', new int[] {0, 1, 2}),
            new Classnode('b', new int[] { 2, 3 }),
            new Classnode('c', new int[] { 1, 2})
        };

        List<char>[] scheduleTable = BuildScheduleTable(4, classNodes);

        PrintScheduleTable(scheduleTable);

       // GetSchedules(scheduleTable, truthTable: new bool[] { false, false, false, false });
    }

    public static List<char>[] BuildScheduleTable(int timeSlots, Classnode[] classes)
    {
        List<char>[] result = new List<char>[timeSlots];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new List<char>();
        }

        foreach (Classnode c in classes)
        {
            foreach (int i in c.timeSlot)
            {
                result[i].Add(c.classLetter);
            }
        }

        for (int i = 0; i < result.Length; i++)
        {
            result[i].Add('0');
        }

        return result;
    }

    public static void PrintScheduleTable(List<char>[] table)
    {
        string finalstr = "| ";

        foreach (List<char> l in table)
        {
            foreach (char c in l)
            {
                finalstr += c + " | ";
            }
            Debug.Log(finalstr);
            finalstr = "| ";
        }
    }

    public static void GetSchedules(List<char>[] scheduleTable,char[] currentSchedule, int currentTimeslot)//, bool[] truthTable)
    {
        List<char> scheduleOption = scheduleTable[currentTimeslot];

      //  foreach (List<char> l in scheduleOption) {
      //
      //      GetSchedules(scheduleTable, currentSchedule, currentTimeslot + 1);
      //  }

        //if (IsScheduleValid(truthTable))
        //    PrintScheduleOption(scheduleOption);
    }

    public static void ToggleTruthTableAtIndex(bool[] truthTable, int index)
    {
        truthTable[index] = !truthTable[index];
    }

    public static bool IsScheduleValid(bool[] truthTable)
    {
        bool result = true;
        int i = 0;
        while (result) {
            if (!truthTable[i])
                result = false;
        }

        return result;
    }

    public static void PrintScheduleOption(List<char> classes)
    {
        string finalstr = "| ";
        foreach (char c in classes)
        {
            finalstr += c + " | ";
        }
        Debug.Log(finalstr);
        finalstr = "| ";

    }

    #region oldcode
    //public void GetSchedules(int timeSlots, int classes, int minClasses, Dictionary<string, int[]> classesTimeSlots, int classParam, int slotParam, Stack<string> outputParam)
    //{
    //    string singleOutput;
    //    Stack<string> currentOutput = outputParam;
    //    int currentClass = classParam;
    //    int currentSlot = slotParam;



    //    while (timeSlots >= currentSlot)
    //    {
    //        char letter = (char)('a' + ((currentClass - 1) % 26));

    //        while (classes >= currentClass)
    //        {
    //            for (int i = 0; i < classesTimeSlots[Convert.ToString(letter)].Length; i++)
    //            {
    //                if (currentSlot == (int)classesTimeSlots[Convert.ToString(letter)].GetValue(i) && !currentOutput.Contains(letter.ToString()))
    //                    currentOutput.Push("" + currentSlot);

    //                //else
    //                //    currentOutput.Push("" + 0);
    //            }
    //            currentSlot++;
    //            GetSchedules(timeSlots, classes, minClasses, classesTimeSlots, currentClass, currentSlot, currentOutput);
    //        }

    //        string sf = "|";
    //        while (currentOutput.Count > 0)
    //        {
    //            sf += currentOutput.Pop() + " | ";

    //        }
    //        Debug.Log("Class " + letter + " " + sf);

    //        currentSlot = 1;
    //        currentClass++;

    //    }

    //}
    #endregion
}
