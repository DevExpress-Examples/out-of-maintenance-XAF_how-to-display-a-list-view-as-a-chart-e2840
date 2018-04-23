using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using System.Collections;
using System.Collections.Generic;

namespace ChartExample.Module {
    public class Updater : ModuleUpdater {
        public Updater(ObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i <= 5; i++) {
                employees.Add(ObjectSpace.CreateObject<Employee>());
            }
            employees[0].FirstName = "Mary";
            employees[0].LastName = "Tellitson";
            employees[0].Position = "Developer";

            employees[1].FirstName = "Robert";
            employees[1].LastName = "King";
            employees[1].Position = "Senior Developer";

            employees[2].FirstName = "Steven";
            employees[2].LastName = "Buchanan";
            employees[2].Position = "Developer";

            employees[3].FirstName = "Nancy";
            employees[3].LastName = "Davolio";
            employees[3].Position = "Developer";

            employees[4].FirstName = "Michael";
            employees[4].LastName = "Suyama";
            employees[4].Position = "Developer";

            employees[5].FirstName = "Andrew";
            employees[5].LastName = "Fuller";
            employees[5].Position = "Sales Manager";

            foreach (Employee employee in employees) {
                employee.Save();
            }
        }
    }
}
