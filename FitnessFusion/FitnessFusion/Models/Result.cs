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
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
        public double Mass { get; set; }
        public double Height { get; set; }
        [DisplayName("Neck Circumference")]
        public double NeckCircumference { get; set; }
        [DisplayName("Waist Circumference")]
        public double WaistCircumference { get; set; }
        [DisplayName("Arm Circumference")]
        public double ArmCircumference { get; set; }
        [DisplayName("Hips Circumference")]
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

        /*
            U odgovarajucem kontroleru Result klase, ovisno kako bude implementiran, bice potrebno dodati kod za postavljanje atributa
            koje racuna API. U slucaju da se budu prikazivali svi rezultati na jednoj stranici i da imamo neki kao 'Index' kontroler,
            kod koji bi sve potrebne API atribute postavio izgledao bi otprilike ovako:

            List<Result> results = await _context.Result.ToListAsync();
            foreach (var result in results)
            {
                String userID = _context.User.Find(result.UserId).ApplicationUserId;
                int activityLevel = _context.User.Find(result.UserId).ActivityCoefficient;
                DateTime birth = _context.Users.Find(userID).DateOfBirth;
                Char sex = _context.Users.Find(userID).Sex;
                int age = DateTime.Today.Year - birth.Year;             
                if (DateTime.Today < dateOfBirth.AddYears(age))
                {
                    age--;
                }
                String gender; 
                if(sex == 'M' || 'm')
                    gender = "male";
                else
                    gender = "female";
                // ovaj dio do sada sa dobavljanjem age, gender i activity coeff iz baze se moze odvojiti u neku privatnu metodu kontrolera
                await result.calculateBMI(age, result.Mass, result.Height);
                await result.calculateBodyFatPercentage(age, gender, result.Mass, result.Height, result.NeckCircumference, result.WaistCircumference, result.HipsCircumference);
                await result.calculateBMR(age, gender, result.Height, result.Mass, activityLevel);
            }
            return View(await _context.Result.ToListAsync());

        */

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
