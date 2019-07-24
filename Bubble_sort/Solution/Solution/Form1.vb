Public Class Form1

    Private Sub sort_Click(sender As Object, e As EventArgs) Handles sort.Click

        bar.Visible = False                                                       ' Make chart Visible for showing Animation
        lebel.Visible = False

        bar.Series("Value Of Elemnts").Points.Clear()   ' Clear the Bar before Going Further
       


        Dim i, dot_count As Integer                     ' For looping
        Dim j As Integer = 0                            ' For Couting Purpose
        Dim temp As String = ""                         ' temp For Storing Tempory Strings Which Will be Converted to Doubles
        Dim temp_string As String = input.Text          ' Storing the Input String
        Dim input_array() As Double = {}                ' Initializing input_array of Doubles


        ' Checking the Input Of Number Of keys If it is Correct Or Not

        For i = 0 To Len(keys.Text) - 1
            If (keys.Text = "") Or Not (Asc(keys.Text(i)) >= Asc("0") And Asc(keys.Text(i)) <= Asc("9")) Then
                MessageBox.Show("Have You Given Proper Input Of Number Of Keys in Appropriate Box ???", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Exit Sub
            End If
        Next
        ReDim input_array(keys.Text - 1)                        ' Redeclaring Dynamic Array of Size Keys.Text






        ' Checking the validity of Input String And traversing Strings And convert them to Doubles
        dot_count = 0
        For i = 0 To Len(input.Text) - 1

            ' Checking Validity Of String For Differnt Cases And Different Corner Cases

            If (((Asc(temp_string(i)) <= Asc("9")) And (Asc(temp_string(i)) >= Asc("0"))) Or ((Asc(temp_string(i)) = Asc("-")) And (temp = "")) Or (Asc(temp_string(i)) = Asc(".") And dot_count = 0)) Then
                temp = temp & temp_string(i)
                If (temp_string(i) = ".") Then
                    dot_count = dot_count + 1
                End If
            ElseIf (Not (temp = "")) And (Asc(temp_string(i)) = Asc(" ")) And Not (temp_string(i) = ".") Then
                input_array(j) = CDbl(temp)
                temp = ""
                j = j + 1  'j is array index for the input array we are generating
                dot_count = 0
            ElseIf (temp = "") And temp_string(i) = " " Then
                temp = ""


            Else    ' Else For Other String Which Are not Valid
                If MessageBox.Show("Syntax Error: This Type of Input is not Valid....." + temp + temp_string(i) + "...is Not Valid ", "Syntax error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Cancel Then

                    Me.Close()

                    Exit Sub  ' Exit Sub If Input Is Not Valid And User Wants to Cancel


                Else
                    start.PerformClick()

                    Exit Sub
                End If
            End If

            If i = Len(input.Text) - 1 And ((Asc(temp_string(i)) <= Asc("9")) And (Asc(temp_string(i)) >= Asc("0"))) Then
                input_array(j) = CDbl(temp)
                j = j + 1

            End If


            ' Checking If Number Of Inputs Are Properly IN Input Or Not
            If (j = keys.Text) Then   ' Breaking Loop If i get All Inputs In input
                Exit For
            End If


        Next

        

        If (j = keys.Text) Then
            sort.Enabled = False    ' Disabled Sort Button Untill Sort is Complete

            ' Creating Animations For User|| Creating Chart Of Inputs
            For i = LBound(input_array) To UBound(input_array)

                Me.bar.Series("Value Of Elemnts").Points.AddXY(i, input_array(i))
                bar.Series("Value Of Elemnts").Points(i).Color = Color.SteelBlue
            Next



            bubble_sort(input_array)    ' Function bubble_sort For Sorting input_array



            'Some Anim,ations Effects
            list.Visible = True
            lb.Visible = True

            'Finally Printing Sorted Atrray in Rich text Box
            Dim LineOfText As String = String.Join(" ", input_array)
            list.Text = (LineOfText)

        Else   ' Executes If Less Numbe rOf inputs Are in input
            If MessageBox.Show("Your Input Is Not Complete. Please Complete It. Choose What To do Next", "Syntax error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Cancel Then

                Me.Close()
                Exit Sub

            Else

                sort.Enabled = True
                Exit Sub

            End If

            End If
        sort.Enabled = True
        lebel.Visible = False

    End Sub





    Private Sub bubble_sort(ByVal input() As Double)
        Dim i, j, check_button As Integer                                                      ' Variables for loop management

        bar.Visible = True
        lebel.Visible = True

        If r1.Checked = True Then                                                ' Check What Type Of sort to be Performed
            check_button = 0
        ElseIf r2.Checked = True Then
            check_button = 1
        End If


        For i = 0 To UBound(input)                                               ' Algorithm Of Bubble Sort // Traverse Elements From 0 to End

            For j = 0 To UBound(input) - i - 1                                   ' Traversing From 0 to unsorted Data


                Application.DoEvents()                                           ' Delay Time
                System.Threading.Thread.Sleep(2000)



                lebel.Text = ("Checking Both The Numbers If Preecing One is Greater Than Later One")
                bar.Series("Value Of Elemnts").Points(j).Color = Color.Yellow  ' Change the colors of bars which are checking
                bar.Series("Value Of Elemnts").Points(j + 1).Color = Color.Yellow


                Application.DoEvents()                                          'Delay of Two Seconds
                System.Threading.Thread.Sleep(2000)

                If (input(j + check_button) > input(j + 1 - check_button)) Then   ' Checking 

                    lebel.Text = ("Swapping takes place since " + CStr(input(j + 1 - check_button)) + " is Less Than " + CStr(input(j + check_button)))
                    bar.Series("Value Of Elemnts").Points(j).Color = Color.Red   ' Changing the colours of Bars
                    bar.Series("Value Of Elemnts").Points(j + 1).Color = Color.Red

                    swap(input, j)                                                ' Swap if j+1 th element is less than jth

                    bar.Series("Value Of Elemnts").Points(j).Color = Color.SteelBlue    ' Change the colors of bars which are checking
                    bar.Series("Value Of Elemnts").Points(j + 1).Color = Color.SteelBlue
                Else
                    bar.Series("Value Of Elemnts").Points(j).Color = Color.Green        ' Change the colors of bars which are checking
                    bar.Series("Value Of Elemnts").Points(j + 1).Color = Color.Green
                    lebel.Text = (" No Swapping takes place since " + CStr(input(j + check_button)) + " is Less Than " + CStr(input(j + 1 - check_button)))
                    Application.DoEvents()
                    System.Threading.Thread.Sleep(1000)
                    bar.Series("Value Of Elemnts").Points(j).Color = Color.SteelBlue    ' Change the colors of bars which are checking
                    bar.Series("Value Of Elemnts").Points(j + 1).Color = Color.SteelBlue

                End If
              
                lebel.Text = ("")

            Next

            bar.Series("Value Of Elemnts").Points(j).Color = Color.DarkRed
            Application.DoEvents()                                                  'Delay Of some Time
            System.Threading.Thread.Sleep(2000)            ' Finally Stabilizing the colors of bars Which Are Sorted
        Next

        Application.DoEvents()                                                          ' Delay Of some Time
        System.Threading.Thread.Sleep(3000)
        lebel.Visible = False
    End Sub


    ' Swap Function For Swapping Elemets
    Private Sub swap(ByVal input() As Double, ByVal j As Integer)    ' Array(input) and the index(j th and j+1 th Number Are to be swapped) As Arguments
        Dim temp As Double                                           ' temporary variable for swapping


        ' Swap the Numbers
        temp = input(j)
        input(j) = input(j + 1)
        input(j + 1) = temp

        ' Stop there For Some Time
        Application.DoEvents()
        System.Threading.Thread.Sleep(3000)


        ' Changing the Bars And Colors of Bars 
        bar.Series("Value Of Elemnts").Points.ElementAt(j + 1).SetValueY(input(j + 1))
        bar.Series("Value Of Elemnts").Points.ElementAt(j).SetValueY(input(j))
        
        Application.DoEvents()
        System.Threading.Thread.Sleep(2000)


    End Sub

    

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        list.Clear()
        input.Text = ""
        bar.Series("Value Of Elemnts").Points.Clear()

        keys.Clear()
        bar.Visible = False
        lebel.Visible = False
        lb.Visible = False
        list.Visible = False
    End Sub


    Private Sub ex_Click_1(sender As Object, e As EventArgs) Handles ex.Click
        Me.Close()
        Exit Sub
    End Sub

    
    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub bar_Click(sender As Object, e As EventArgs) Handles bar.Click

    End Sub

    Private Sub r1_CheckedChanged(sender As Object, e As EventArgs) Handles r1.CheckedChanged
        If (bar.Visible = True) And r1.Checked = True Then
            sort.PerformClick()
        End If
    End Sub

    Private Sub r2_CheckedChanged(sender As Object, e As EventArgs) Handles r2.CheckedChanged
        If (bar.Visible = True) And r2.Checked = True Then
            sort.PerformClick()
        End If
    End Sub

   
End Class



