using EngineeringUnits;
using Fractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace UnitNetcomparing
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = 10000;

            Stopwatch stopwatch2 = Stopwatch.StartNew();
            for (int i = 0; i < k; i++)
            {
                MassFlow testee = MassFlow.FromKilogramsPerSecond(i);
            }
            stopwatch2.Stop();

            Debug.Print($"Create new Massflow: {stopwatch2.ElapsedTicks / k} tick/creation");
            


            MassFlow test1 = MassFlow.FromKilogramsPerSecond(654);
            MassFlow test2 = MassFlow.FromKilogramsPerSecond(158.547);
            MassFlow test3 = MassFlow.Zero;

            stopwatch2.Restart();
            for (int i = 0; i < k; i++)
            {
                test3 = test1 + test2;
            }
            stopwatch2.Stop();

            Debug.Print($"add 1 time: {stopwatch2.ElapsedTicks / k} tick/addition");



            stopwatch2.Restart();
            for (int i = 0; i < k; i++)
            {
                test3 = test1 - test2;
            }
            stopwatch2.Stop();

            Debug.Print($"sub 1 time: {stopwatch2.ElapsedTicks / k} tick/sub");



            Length length = Length.FromMeters(132);
            Area area = Area.Zero;


            stopwatch2.Restart();
            for (int i = 0; i < k; i++)
            {
                area = length * length;
            }
            stopwatch2.Stop();

            Debug.Print($"Multiply 1 times: {stopwatch2.ElapsedTicks / k} tick/multi");






            Duration duration = Duration.FromHours(3);
            Speed speed = Speed.FromMetersPerSecond(3);

            stopwatch2.Restart();
            for (int i = 0; i < k; i++)
            {
                speed = length / duration;
            }
            stopwatch2.Stop();

            Debug.Print($"Divide 1 times: {stopwatch2.ElapsedTicks / k} tick/division");



            Length length2 = Length.FromMeters(132);
            bool check = true;
            stopwatch2.Restart();
            for (int i = 0; i < k; i++)
            {
                check = length <= length2;
            }
            stopwatch2.Stop();

            Debug.Print($"'<=' 1 time: {stopwatch2.ElapsedTicks / k} tick/operation");


        }
    }
}
