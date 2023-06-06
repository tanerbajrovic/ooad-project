using System;

namespace FitnessFusion.Models.BuilderDP
{
    public class ResultBuilder : IBuilder
    {
        private Result _result = new Result();
        public void AddIDTrainer(int id)
        {
            _result.IDTrainer = id;
        }
        public void AddAbsTest(int absTest)
        {
            _result.AbsTest = absTest;
        }

        public void AddBenchPress(double benchPress)
        {
            _result.BenchPress = benchPress;
        }

        public void AddCalories(int calories)
        {
            _result.Calories = calories;
        }

        public void AddDate(DateTime date)
        {
            _result.Date = date;
        }

        public void AddHeight(double height)
        {
            _result.Height = height;
        }
        public void AddArmCircumference(double armCircumference)
        {
            _result.ArmCircumference = armCircumference;
        }
        public void AddHipsCircumference(double hipsCircumference)
        {
            _result.HipsCircumference = hipsCircumference;
        }
        public void AddWaistCircumference(double waistCircumference)
        {
            _result.WaistCircumference = waistCircumference;
        }

        public void AddLegCircumference(double legCircumference)
        {
            _result.LegCircumference = legCircumference;
        }

        public void AddMass(double mass)
        {
            _result.Mass = mass;
        }

        public void AddNeckCircumference(double neckCircumference)
        {
            _result.NeckCircumference = neckCircumference;
        }

        public void AddPushUps(int pushUps)
        {
            _result.PushUps = pushUps;
        }

        public void AddRunning(double running)
        {
            _result.Running = running;
        }

        public void AddSprintRunning(double sprintRunning)
        {
            _result.SprintRunning = sprintRunning;
        }

        public void AddSquat(double squat)
        {
            _result.Squat = squat;
        }

        public void AddVerticalJump(double verticalJump)
        {
            _result.VerticalJump = verticalJump;
        }
        public void AddHorizontalJump(double horizontalJump)
        {
            _result.HorizontalJump = horizontalJump;
        }

        public Result Build()
        {
            return _result;
        }
    }
}
