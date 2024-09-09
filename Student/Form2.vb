Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.StudentDataSet.Table1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Table1BindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        On Error GoTo saveerror


        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(StudentDataSet.Table1)

        Me.Table1TableAdapter.Fill(Me.StudentDataSet.Table1)

saveerror:


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Table1BindingSource.RemoveCurrent()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Table1BindingSource.MovePrevious()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Table1BindingSource.MoveNext()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.Close()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Mypicture As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        With OpenFileDialog1
            .Filter = "jpg, jpeg Image|*.jpg, jpeg|PNG Image|*.PNG|BMP Image|*.bmp|" & "All Files (*.*)|*.*"
            .Title = "Choose the Picture..."
            .FilterIndex = 1
            .Multiselect = False
            .ValidateNames = True
            .InitialDirectory = Mypicture
            .RestoreDirectory = True

            If (.ShowDialog = DialogResult.OK) Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Else
                Return

            End If

        End With
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "BE/B.Tech- Bachelor of Technology" Then
            TextBox4.Text = "₹ 137,000 per year"
        ElseIf ComboBox2.Text = "B.Arch- Bachelor of Architecture" Then
            TextBox4.Text = "₹ 137,000 per year"
        ElseIf ComboBox2.Text = "BCA- Bachelor of Computer Applications" Then
            TextBox4.Text = "₹ 80,000 per year"
        ElseIf ComboBox2.Text = "M.C.A- Master of Computer Applications " Then
            TextBox4.Text = "₹ 109,000 per year"
        ElseIf ComboBox2.Text = "B.Sc.- Information Technology" Then
            TextBox4.Text = "₹ 73,000 per year"
        ElseIf ComboBox2.Text = "B.sc- Data science" Then
            TextBox4.Text = "₹ 86,000 per year"
        ElseIf ComboBox2.Text = "BPharma- Bachelor of Pharmacy" Then
            TextBox4.Text = "₹ 138,000 per year"
        ElseIf ComboBox2.Text = "MBA- Master of Business Administration " Then
            TextBox4.Text = "₹ 145,000 per year"
        ElseIf ComboBox2.Text = "BBA- Bachelor of Business Administration" Then
            TextBox4.Text = "₹ 105,000 per year"
        ElseIf ComboBox2.Text = "L.L.B- Bachelor of Law " Then
            TextBox4.Text = "₹ 62,000 per year"
        ElseIf ComboBox2.Text = "BA in History" Then
            TextBox4.Text = "₹ 99,000 per year"
        ElseIf ComboBox2.Text = "B.Ed- Bachelor of Education " Then
            TextBox4.Text = "₹ 67,000 per year"
        ElseIf ComboBox2.Text = "L.L.M- Master of Laws " Then
            TextBox4.Text = "₹ 80,000 per year"
        ElseIf ComboBox2.Text = "Ph.D.- Management Studies" Then
            TextBox4.Text = "₹ 85,000 per year"
        ElseIf ComboBox2.Text = "M.Tech- Master of Technology" Then
            TextBox4.Text = "₹ 112,000 per year"
        ElseIf ComboBox2.Text = "B.Tech- Biotechnology" Then
            TextBox4.Text = "₹ 136,000 per year"

        End If
    End Sub
End Class