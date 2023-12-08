using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Controllers.DataBaseController dbController = new Controllers.DataBaseController();
            Controllers.HtmlController htmlController = new Controllers.HtmlController();

            List<Models.House3> participants;

            try
            {
                participants = htmlController.GetParticipants();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Для завершения работы нажмите на любую кнопку");
                Console.ReadKey();
                return;
            }

            foreach (Models.House3 participant in participants)
            {
                Console.WriteLine("Участник: " + participant.Name);
                Console.WriteLine("Пришел (пришла): " + participant.Start);
                Console.WriteLine("Ушел (ушла): " + participant.End);
                Console.WriteLine();

                dbController.Insert(participant);
            }

            Console.WriteLine("Для завершения работы нажмите на любую кнопку");
            Console.ReadKey();


        }
    }
}
