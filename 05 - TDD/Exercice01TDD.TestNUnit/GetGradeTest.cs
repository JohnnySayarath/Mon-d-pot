using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01TDD.TestNUnit
{
    [TestFixture]
    public class GetGradeTest
    {
        [Test]
        public void WhenGrading_ScoreIs95_And_AttendanceIs90_Except_A()
        {
            // Arrange
            var gradingCalculator = new GradingCalculator();
            gradingCalculator.Score = 95;
            gradingCalculator.AttendancePercentage = 90;
            // Act
            char result = gradingCalculator.GetGrade();

            // Assert
            Assert.That(result, Is.EqualTo('A'));
        }

        [Test]
        public void WhenGrading_ScoreIs85_And_AttendanceIs90_Except_B()
        {
            // Arrange
            var gradingCalculator = new GradingCalculator();
            gradingCalculator.Score = 85;
            gradingCalculator.AttendancePercentage = 90;
            // Act
            char result = gradingCalculator.GetGrade();

            // Assert
            Assert.That(result, Is.EqualTo('B'));
        }

        [Test]
        public void WhenGrading_ScoreIs65_And_AttendanceIs90_Except_C()
        {
            // Arrange
            var gradingCalculator = new GradingCalculator();
            gradingCalculator.Score = 65;
            gradingCalculator.AttendancePercentage = 90;

            // Act
            char result = gradingCalculator.GetGrade();

            // Assert
            Assert.That(result, Is.EqualTo('C'));
        }

        [Test]
        public void WhenGrading_ScoreIs95_And_AttendanceIs65_Except_B()
        {
            // Arrange
            var gradingCalculator = new GradingCalculator();
            gradingCalculator.Score = 95;
            gradingCalculator.AttendancePercentage = 65;
            // Act
            char result = gradingCalculator.GetGrade();

            // Assert
            Assert.That(result, Is.EqualTo('B'));
        }

        [Test]
        public void WhenGrading_ScoreIs95_And_AttendanceIs55_Except_F()
        {
            // Arrange
            var gradingCalculator = new GradingCalculator();
            gradingCalculator.Score = 95;
            gradingCalculator.AttendancePercentage = 55;


            // Act
            char result = gradingCalculator.GetGrade();

            // Assert
            Assert.That(result, Is.EqualTo('F'));
        }

        [Test]
        public void WhenGrading_ScoreIs65_And_AttendanceIs55_Except_F()
        {
            // Arrange
            var gradingCalculator = new GradingCalculator();
            gradingCalculator.Score = 65;
            gradingCalculator.AttendancePercentage = 55;


            // Act
            char result = gradingCalculator.GetGrade();

            // Assert
            Assert.That(result, Is.EqualTo('F'));
        }

        [Test]
        public void WhenGrading_ScoreIs50_And_AttendanceIs90_Except_F()
        {
            // Arrange
            var gradingCalculator = new GradingCalculator();
            gradingCalculator.Score = 50;
            gradingCalculator.AttendancePercentage = 90;


            // Act
            char result = gradingCalculator.GetGrade();

            // Assert
            Assert.That(result, Is.EqualTo('F'));
        }

    }
}
