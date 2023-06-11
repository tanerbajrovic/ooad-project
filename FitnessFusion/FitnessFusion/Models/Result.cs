using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http;
using System.Threading.Tasks;

namespace FitnessFusion.Models
{
    public class Result
    {
        #region Properties

        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Trainer")]
        public string TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }

        [Range(40, 160, ErrorMessage = "Mass must be between 40 and 160.")]
        public double Mass { get; set; }

        [Range(130, 230, ErrorMessage = "Height must be between 130 and 230.")]
        public double Height { get; set; }
        [DisplayName("Neck Circumference")]
        [Range(20, 80, ErrorMessage = "Neck circumference must be between 20 and 80.")]
        public double NeckCircumference { get; set; }
        [DisplayName("Waist Circumference")]
        [Range(40, 130, ErrorMessage = "Waist circumference must be between 40 and 130.")]
        public double WaistCircumference { get; set; }
        [DisplayName("Arm Circumference")]
        public double ArmCircumference { get; set; }
        [DisplayName("Hips Circumference")]
        [Range(40, 130, ErrorMessage = "Hips circumference must be between 40 and 130.")]
        public double HipsCircumference { get; set; }
        [DisplayName("Leg Circumference")]
        public double LegCircumference { get; set; }
        [DisplayName("Bench Press")]
        public double BenchPress { get; set; }
        public double Squat { get; set; }
        [DisplayName("Abs Test")]
        public int AbsTest { get; set; }
        public int PushUps { get; set; }
        [DisplayName("Sprint Running")]
        public double SprintRunning { get; set; }
        public double Running { get; set; }
        [DisplayName("Vertical Jump")]
        public double VerticalJump { get; set; }
        [DisplayName("Horizontal Jump")]
        public double HorizontalJump { get; set; }

        public double BMI;

        public double bodyFatPercentage;

        public double BMR;

        #endregion

        #region Constructor

        public Result() { }

        #endregion

        #region Methods

         public String ImportantResultInfo()
        {
            return "Mass: " + Mass + "      Calories: " + Calories;
        }
        public String ResultInfo()
        {
            String resultInfo="";
            //check if there are strenght attributesn- CHECK IF NULL OR 0 
          if(BenchPress!=null)
            {
                resultInfo = "Bench Press: " + BenchPress + "\n" + "Squat: " + Squat + "\n" + "Abs test: " + AbsTest + "\n"
                    + "PushUps: " + PushUps + "\n";
            }
          //check if there are cardio parameters
          if(SprintRunning!=null)
            {
                resultInfo += "Sprint running (200m): " + SprintRunning + "\n" + "Running (5k): " + Running + "\n"
                    + "Vertical jump: " + VerticalJump + "\n" + "Horizontal jump: " + HorizontalJump + "\n";
            }
            return resultInfo;
        }


        public async Task calculateBMI(int age, double weight, double height)
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "df549c87b4msh3330fdcc45e9f99p1cb5e0jsnaa3a3c152a14");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "fitness-calculator.p.rapidapi.com");

                var requestUri = $"https://fitness-calculator.p.rapidapi.com/bmi?age={age}&weight=={weight}&height={height}";
                var response = await client.GetAsync(requestUri);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<dynamic>(responseBody);
                this.BMI = responseObj.data.bmi;
            }

        }

        public async Task calculateBodyFatPercentage(int age, string gender, double weight, double height, double neck, double waist, double hip)
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "df549c87b4msh3330fdcc45e9f99p1cb5e0jsnaa3a3c152a14");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "fitness-calculator.p.rapidapi.com");

                var requestUri = $"https://fitness-calculator.p.rapidapi.com/bodyfat?age={age}&gender={gender}&weight={weight}&height={height}&neck={neck}&waist={waist}&hip={hip}";
                var response = await client.GetAsync(requestUri);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<dynamic>(responseBody);
                this.bodyFatPercentage = responseObj.data["Body Fat (U.S. Navy Method)"];
            }

        }

        public async Task calculateBMR(int age, string gender, double height, double weight, int activityLevel)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "df549c87b4msh3330fdcc45e9f99p1cb5e0jsnaa3a3c152a14");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "fitness-calculator.p.rapidapi.com");
                string activity = "level_" + activityLevel;
                var requestUri = $"https://fitness-calculator.p.rapidapi.com/dailycalorie?age={age}&gender={gender}&height={height}&weight={weight}&activitylevel={activity}";
                var response = await client.GetAsync(requestUri);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var responseObj = JsonConvert.DeserializeObject<dynamic>(responseBody);
                this.BMR = responseObj.data.BMR;
            }
        }
        #endregion
    }
}
