Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim og As New car1.CarGroup
        og.Category = "a"
        og.Name = "Velho"
        og.Save()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim obj As New car1.Car
        'obj.MinDays = 1
        'obj.SerialNumber = 12317
        'obj.VehicleType = "Chrysler"
        'obj.VehicleStatus = car1.VehicleStatus.Available


        'obj.Save()

        'For Each scar In car1.CarCollection.LoadByVT("Ferrari")
        '    Console.WriteLine(scar.SerialNumber)
        'Next
        'For Each scar In car1.CarCollection.SearchByVT(Nothing, Nothing, Nothing, Nothing)
        Console.WriteLine(car1.NewCarCollection.SearchAll(Nothing, Nothing, Nothing, Nothing, Nothing).Count)




        For Each scar In car1.NewCarCollection.SearchAll(Nothing, Nothing, Nothing, Nothing, Nothing)
            Console.WriteLine(scar.id)
        Next


        'Dim Obj = car1.Car.LoadById(3)

        'Obj.SerialNumber = "1337"
        'Obj.CarGroup = car1.CarGroup.Load(1)
        'Obj.Save()


        'car1.Car.Delete(car1.Car.LoadById(6))




        dgv.DataSource = car1.CarCollection.LoadByVT

  
        'Dim obj As New car1.Car

        'TextBox1.DataBindings.Add(Text, obj.Id, )

        'Me.BindingSource1.DataSource = GetType(Global.car1.car1.Car)


        'car1.Customer.CheckCredentials()

        'car1.RentalAgreementCollection.LoadByPickupDateAndUser()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub
End Class
