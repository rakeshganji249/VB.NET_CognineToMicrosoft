
Imports System
Imports System.Security.Cryptography

Namespace DataAccessConverssion

    Module Program
        Sub Main(args As String())
            Dim cognineEmployees As New List(Of EmployeeCognine) From {
                New EmployeeCognine With {.employeeId = 12, .name = "Rakesh", .phoneNumber = 9876543210, .email = "rakesh@gmail.com"},
                New EmployeeCognine With {.employeeId = 13, .name = "Rakes", .phoneNumber = 9876545678, .email = "rakeshganji@gmail.com"},
                 New EmployeeCognine With {.employeeId = 14, .name = "Raki", .phoneNumber = 9876678901, .email = "rakeshg@gmail.com"}
            }

            Dim microsoftEmployees As List(Of EmployeeMicrosoft) = (
            From employees In cognineEmployees
            Select New EmployeeMicrosoft With {
                .employeeId = employees.employeeId,
                .name = employees.name,
                .phoneNumber = employees.phoneNumber,
                .email = employees.email
            }
        ).ToList()

            For Each employee As EmployeeMicrosoft In microsoftEmployees
                Console.WriteLine($"Id: {employee.employeeId}, Name: {employee.name}, PhoneNumber: {employee.phoneNumber}, Email:{employee.email}")
                ' Output other properties of EmpMicrosoft if needed
            Next


        End Sub
    End Module
End Namespace

