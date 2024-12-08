using Common_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<AlertAssignment> AlertAssignments { get; set; }
        public DbSet<AnalyticsTransaction> AnalyticsTransactions { get; set; }
        public DbSet<ANPRTransaction> ANPRTransactions { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<AttendanceTransaction> AttendanceTransactions { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceHealth> DeviceHealths { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<ECBTransaction> ECBTransactions { get; set; }
        public DbSet<ELock> ELocks { get; set; }
        public DbSet<ELockTransaction> ELockTransactions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<FloodTransaction> FloodTransactions { get; set; }
        public DbSet<GPS> GPS { get; set; }
        public DbSet<GPSTransaction> GPSTransactions { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageTemplate> MessageTemplates { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<PinCode> PinCodes { get; set; }
        public DbSet<Pole> Poles { get; set; }
        public DbSet<PostTemplate> PostTemplates { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionGroup> QuestionGroups { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Models.Route> Routes { get; set; }
        public DbSet<RouteDetail> RouteDetails { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<SLA> SLAs { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<TaskInfo> TaskInfos { get; set; }
        public DbSet<Tehsil> Tehsils { get; set; }
        public DbSet<TPPassTransaction> TPPassTransactions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserJob> UserJobs { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<VehicleDriver> VehicleDrivers { get; set; }
        public DbSet<VehicleGPS> VehicleGPS { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<VMDTransaction> VMDTransactions { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Zone> Zones { get; set; }
    }
}
