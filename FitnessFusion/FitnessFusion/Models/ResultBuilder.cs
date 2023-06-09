using System;

namespace FitnessFusion.Models.BuilderDP
{
    public class ResultBuilder : IBuilder
    {
        private Result result = new Result();
        public void AddTrainerId(string id)
        {
            result.TrainerId = id;
        }
        public void AddAbsTest(int absTest)
        {
            result.AbsTest = absTest;
        }

        public void AddBenchPress(double benchPress)
        {
            result.BenchPress = benchPress;
        }

        public void AddCalories(int calories)
        {
            result.Calories = calories;
        }

        public void AddDate(DateTime date)
        {
            result.Date = date;
        }

        public void AddHeight(double height)
        {
            result.Height = height;
        }
        public void AddArmCircumference(double armCircumference)
        {
           result.ArmCircumference = armCircumference;
        }
        public void AddHipsCircumference(double hipsCircumference)
        {
            result.HipsCircumference = hipsCircumference;
        }
        public void AddWaistCircumference(double waistCircumference)
        {
            result.WaistCircumference = waistCircumference;
        }

        public void AddLegCircumference(double legCircumference)
        {
            result.LegCircumference = legCircumference;
        }

        public void AddMass(double mass)
        {
            result.Mass = mass;
        }

        public void AddNeckCircumference(double neckCircumference)
        {
            result.NeckCircumference = neckCircumference;
        }

        public void AddPushUps(int pushUps)
        {
            result.PushUps = pushUps;
        }

        public void AddRunning(double running)
        {
            result.Running = running;
        }

        public void AddSprintRunning(double sprintRunning)
        {
            result.SprintRunning = sprintRunning;
        }

        public void AddSquat(double squat)
        {   
            result.Squat = squat;
        }

        public void AddVerticalJump(double verticalJump)
        {
            result.VerticalJump = verticalJump;
        }
        public void AddHorizontalJump(double horizontalJump)
        {
            result.HorizontalJump = horizontalJump;
        }

        public Result Build()
        {
            return result;
        }
    }
}
