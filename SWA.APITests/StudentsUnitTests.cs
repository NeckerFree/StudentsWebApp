using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using SWA.DataAccess.Models;
using System.Net;
using System.Net.Http.Json;

namespace SWA.APITests
{
    public class StudentsUnitTests
    {
        [Fact]
        public async void GetStudentById()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            var response = await client.GetAsync($"/api/students/{1}");
            var data = await response.Content.ReadAsStringAsync();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async void GetAllStudents()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            var response = await client.GetAsync("/api/students");
            var data = await response.Content.ReadAsStringAsync();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }


        [Fact]
        public async void CreateStudent()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            Student student = new Student()
            {
                Id = 0,
                Age = 45,
                Career = "Doctor",
                FirstName = "Jacobo",
                LastName = "Burton",
                Username = "Jack"
            };
            var content = JsonConvert.SerializeObject(student);
            var response = await client.PostAsJsonAsync("/api/students", content);
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        [Fact]
        public async void UpdateStudent()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            Student student = new Student()
            {
                Id = 9,
                Age = 45,
                Career = "Lawyer",
                FirstName = "Jacobo",
                LastName = "Burton",
                Username = "Jackie"
            };
            var content = JsonConvert.SerializeObject(student);
            var response = await client.PutAsJsonAsync("/api/students", content);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async void DeleteStudent()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();
            Student student = new Student();
            var content = JsonConvert.SerializeObject(student);
            var response = await client.DeleteAsync($"/api/students/{55}");
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

    }
}