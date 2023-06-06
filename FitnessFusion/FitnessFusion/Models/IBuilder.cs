using System;

namespace FitnessFusion.Models.BuilderDP
{
    public interface IBuilder
    {
        void AddIDTrainer(int id);
        void AddCalories(int calories);
        void AddDate(DateTime date);
        void AddMass(double mass);
        void AddHeight(double height);
        void AddNeckCircumference(double neckCircumference);
        void AddWaistCircumference(double waistCircumference);
        void AddArmCircumference(double armCircumference);
        void AddHipsCircumference(double hipsCircumference);
        void AddLegCircumference(double legCircumference);
        void AddBenchPress(double benchPress);
        void AddSquat(double squat);
        void AddAbsTest(int absTest);
        void AddPushUps(int pushUps);
        void AddSprintRunning(double sprintRunning);
        void AddRunning(double running);
        void AddVerticalJump(double verticalJump);
        void AddHorizontalJump(double horizontalJump);

        Result Build();

    }
}
