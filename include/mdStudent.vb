Module mdStudent
    Public StudentID, Father, F_Age, F_EducationaAttainment, F_Occupation, F_EmployerName, _
          F_EmployerAddress, F_Living, Mother, M_Age, M_Living, M_EducationaAttainment, M_Occupation, _
          M_EmployerName, M_EmployerAddress, Guardian, G_Age, G_Living, G_EducationaAttainment, _
          G_Occupation, G_EmployerName, G_EmployerAddress, ParentsMartialReationship, NoofChildren, _
          NoofBrothers, NoofSisters, NoofSisterBrotherGainfullyEmployed, OrdinalPositiom, ProvidingSupport, _
          Allowance, QuitePlaceStudy, ShareRoom, NatureofResidence As String

    Public FirstName, MiddleName, LastName, Sex, CivilStatus, DateofBirth, Age, PlaceofBirth, _
          CityAddress, ProvincialAddress, EmailAddress, TelephoneNo, MobileNo, CourseID, S_Level, S_Section, S_Height, S_Weight, _
          Comlexion, Religion, HighSchoolAve, Employer, PersontobeContact, P_Address, P_Relationship, _
          P_ContactNo As String
    Public Sub Personal_Background(ByVal frm As frmStudent)
        With frm
            StudentID = .txtStudenID.Text
            FirstName = .txtFname.Text
            MiddleName = .txtMname.Text
            LastName = .txtLname.Text
            If .rdoMale.Checked = True Then
                Sex = "Male"
            Else
                Sex = "Female"
            End If
            CivilStatus = .cboCivilStatus.Text
            DateofBirth = formatMySQLdate(.dtpDateofBirth.Text)
            PlaceofBirth = .txtPlaceofBirth.Text
            CityAddress = .txtCityAddress.Text
            ProvincialAddress = .txtProvincialAddress.Text
            EmailAddress = .txtEmailAddress.Text
            TelephoneNo = .txtTelNo.Text
            MobileNo = .txtMobile.Text
            CourseID = .cboCourse.SelectedValue
            S_Level = .cboYear.Text
            S_Section = .txtSection.Text
            S_Height = .txtHeight.Text
            S_Weight = .txtWeight.Text
            Comlexion = .txtComplexion.Text
            Religion = .txtReligion.Text
            HighSchoolAve = .txtHSAve.Text
            Employer = .txtEmloyerandAdd.Text
            PersontobeContact = .txtPersonToBeContact.Text
            P_Address = .txtPAddress.Text
            P_ContactNo = .txtPContactNo.Text
            P_Relationship = .txtPRelationship.Text
            Age = getAge(DateofBirth)
        End With  
    End Sub
    Public Sub HomeAndFamily_Background(ByVal frm As frmStudent)
        With frm
            Father = .txtFather.Text
            F_Age = .txtF_Age.Text
            F_EducationaAttainment = .txtF_EducAttainment.Text
            F_Occupation = .txtF_Occupation.Text
            F_EmployerName = .txtF_Employer.Text
            F_EmployerAddress = .txtF_EmlpoyerAddress.Text
            If .rdoF_Living.Checked = True Then
                F_Living = "Alive"
            ElseIf .rdoF_Deceased.Checked = True Then 
                F_Living = "Deceased"
            End If
            Mother = .txtMother.Text
            M_Age = .txtM_Age.Text
            M_EducationaAttainment = .txtM_EducAttainment.Text
            M_Occupation = .txtM_Occupation.Text
            M_EmployerName = .txtM_Employer.Text
            M_EmployerAddress = .txtM_EmployerAddress.Text
            If .rdoM_Living.Checked = True Then
                M_Living = "Alive"
            ElseIf .rdoM_Deceased.Checked = True Then
                M_Living = "Deceased"
            End If
            Guardian = .txtGuardian.Text
            G_Age = .txtG_Age.Text
            G_EducationaAttainment = .txtG_EducAttainment.Text
            G_Occupation = .txtG_Occupation.Text
            G_EmployerName = .txtG_Employer.Text
            G_EmployerAddress = .txtG_EmployerAddress.Text
            If .rdoG_Living.Checked = True Then
                G_Living = "Alive"
            ElseIf .rdoG_Deceased.Checked = True Then
                G_Living = "Deceased"
            End If

            If .rdoPMR_Married_ST.Checked = True Then
                ParentsMartialReationship = "Married and staying together" 
            ElseIf .rdoPMR_MarriedSeperated.Checked = True Then
                ParentsMartialReationship = "Married but Seperated"
            ElseIf .rdoPMR_NotMarried_LT.Checked = True Then
                ParentsMartialReationship = "Not Married but Living Together"
            ElseIf .rdoPMR_SingleParent.Checked = True Then
                ParentsMartialReationship = "Single Parent"
            ElseIf .rdoPMR_Others.Checked = True Then 
                ParentsMartialReationship = .txtPMR_Others.Text
            End If
            NoofChildren = .txtNoChildren.Text
            NoofBrothers = .txtNoBrothers.Text
            NoofSisters = .txtNoSisters.Text
            NoofSisterBrotherGainfullyEmployed = .txtNoBrothersSisters.Text
            OrdinalPositiom = .txtOrdinalPosition.Text

            If .rdoFamily.Checked = True Then
                ProvidingSupport = "family"
            ElseIf .rdoYourStudies.Checked = True Then
                ProvidingSupport = "your studies"
            ElseIf .rdoHisHerFamily.Checked = True Then
                ProvidingSupport = "his/her own family" 
            End If
            If .rdoParents.Checked = True Then
                Allowance = "Parents"
            ElseIf .rdoBrotherSister.Checked = True Then
                Allowance = "Brother/Sister"
            ElseIf .rdoSpouse.Checked = True Then
                Allowance = "Spouse"
            ElseIf .rdoSelfSupporting.Checked = True Then
                Allowance = "Self-supporting/working students"
            ElseIf .rdoScholarship.Checked = True Then
                Allowance = "Scholarship"
            ElseIf .rdoRelatives.Checked = True Then
                Allowance = "Relatives"
            End If
        End With
    End Sub

    Public Sub loadPersonalBackground()
        Try
            '  Public FirstName, MiddleName, LastName, Sex, CivilStatus, DateofBirth, Age, PlaceofBirth, _
            'CityAddress, ProvincialAddress, EmailAddress, TelephoneNo, MobileNo, CourseID, S_Height, S_Weight, _
            'Comlexion, Religion, HighSchoolAve, Employer, PersontobeContact, P_Address, P_Relationship, _
            'P_ContactNo As String
         
            With dt.Rows(0)
                frmStudent.txtStudenID.Text = .Item("StudentID")
                frmStudent.txtFname.Text = .Item("FirstName")
                frmStudent.txtMname.Text = .Item("MiddleName")
                frmStudent.txtLname.Text = .Item("LastName")
                If .Item("Sex") = "Male" Then
                    frmStudent.rdoMale.Checked = True
                Else
                    frmStudent.rdoFemale.Checked = True
                End If
                frmStudent.cboCivilStatus.Text = .Item("CivilStatus")
                frmStudent.dtpDateofBirth.Text = .Item("DateofBirth")
                frmStudent.txtPlaceofBirth.Text = .Item("PlaceofBirth")
                frmStudent.txtCityAddress.Text = .Item("CityAddress")
                frmStudent.txtProvincialAddress.Text = .Item("ProvincialAddress")
                frmStudent.txtEmailAddress.Text = .Item("EmailAddress")
                frmStudent.txtTelNo.Text = .Item("TelephoneNo")
                frmStudent.txtMobile.Text = .Item("MobileNo")
                frmStudent.cboCourse.SelectedValue = .Item("CourseID")
                frmStudent.cboYear.Text = .Item("S_Level")
                frmStudent.txtSection.Text = .Item("S_Section")
                frmStudent.txtHeight.Text = .Item("S_Height")
                frmStudent.txtWeight.Text = .Item("S_Weight")
                frmStudent.txtComplexion.Text = .Item("Comlexion")
                frmStudent.txtReligion.Text = .Item("Religion")
                frmStudent.txtHSAve.Text = .Item("HighSchoolAve")
                frmStudent.txtEmloyerandAdd.Text = .Item("Employer")
                frmStudent.txtPersonToBeContact.Text = .Item("PersontobeContact")
                frmStudent.txtPAddress.Text = .Item("P_Address")
                frmStudent.txtPContactNo.Text = .Item("P_Relationship")
                frmStudent.txtPRelationship.Text = .Item("P_ContactNo")
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub loadEducationalBackground()
        Try
            frmStudent.dtglist_EducBackground.Rows.Clear()
            findthis(sql)
            LoadData(frmStudent.dtglist_EducBackground, "EducationalBackground")
        Catch ex As Exception

        End Try
    End Sub
    Public Sub loadFamilyBackground()
        Try
          
            With dt.Rows(0)
                frmStudent.txtFather.Text = .Item("Father")
                frmStudent.txtF_Age.Text = .Item("F_Age")
                frmStudent.txtF_EducAttainment.Text = .Item("F_EducationaAttainment")
                frmStudent.txtF_Occupation.Text = .Item("F_Occupation")
                frmStudent.txtF_Employer.Text = .Item("F_EmployerName")
                frmStudent.txtF_EmlpoyerAddress.Text = .Item("F_EmployerAddress")
                If .Item("F_Living") = "Alive" Then
                    frmStudent.rdoF_Living.Checked = True
                ElseIf .Item("F_Living") = "Deceased" Then 
                    frmStudent.rdoF_Deceased.Checked = True
                End If
                frmStudent.txtMother.Text = .Item("Mother")
                frmStudent.txtM_Age.Text = .Item("M_Age")
                frmStudent.txtM_EducAttainment.Text = .Item("M_EducationaAttainment")
                frmStudent.txtM_Occupation.Text = .Item("M_Occupation")
                frmStudent.txtM_Employer.Text = .Item("M_EmployerName")
                frmStudent.txtM_EmployerAddress.Text = .Item("M_EmployerAddress")
                M_Living = .Item("M_Living")
                If M_Living = "Alive" Then
                    frmStudent.rdoM_Living.Checked = True
                ElseIf M_Living = "Deceased" Then
                    frmStudent.rdoM_Deceased.Checked = True
                End If
             
                frmStudent.txtGuardian.Text = .Item("Guardian")
                frmStudent.txtG_Age.Text = .Item("G_Age")
                M_Living = .Item("G_Living")
                frmStudent.txtG_EducAttainment.Text = .Item("G_EducationaAttainment")
                frmStudent.txtG_Occupation.Text = .Item("G_Occupation")
                frmStudent.txtG_Employer.Text = .Item("G_EmployerName")
                frmStudent.txtG_EmployerAddress.Text = .Item("G_EmployerAddress")
                If G_Living = "Alive" Then
                    frmStudent.rdoG_Living.Checked = True
                ElseIf G_Living = "Deceased" Then
                    frmStudent.rdoG_Deceased.Checked = True
                End If
                
                ParentsMartialReationship = .Item("ParentsMartialReationship")
                If ParentsMartialReationship = "Married and staying together" Then
                    frmStudent.rdoPMR_Married_ST.Checked = True
                ElseIf ParentsMartialReationship = "Married but Seperated" Then
                    frmStudent.rdoPMR_MarriedSeperated.Checked = True
                ElseIf ParentsMartialReationship = "Not Married but Living Together" Then
                    frmStudent.rdoPMR_NotMarried_LT.Checked = True
                ElseIf ParentsMartialReationship = "Single Parent" Then
                    frmStudent.rdoPMR_SingleParent.Checked = True
                Else
                    frmStudent.rdoPMR_Others.Checked = True
                End If
                frmStudent.txtNoChildren.Text = .Item("NoofChildren")
                frmStudent.txtNoBrothers.Text = .Item("NoofBrothers")
                frmStudent.txtNoSisters.Text = .Item("NoofSisters")
                frmStudent.txtNoBrothersSisters.Text = .Item("NoofSisterBrotherGainfullyEmployed")
                frmStudent.txtOrdinalPosition.Text = .Item("OrdinalPositiom")

                ProvidingSupport = .Item("ProvidingSupport")
                If ProvidingSupport = "family" Then
                    frmStudent.rdoFamily.Checked = True
                ElseIf ProvidingSupport = "your studies" Then
                    frmStudent.rdoYourStudies.Checked = True
                ElseIf ProvidingSupport = "his/her own family" Then
                    frmStudent.rdoHisHerFamily.Checked = True
                End If
           
                Allowance = .Item("Allowance")
                If Allowance = "Parents" Then
                    frmStudent.rdoParents.Checked = True
                ElseIf Allowance = "Brother/Sister" Then
                    frmStudent.rdoBrotherSister.Checked = True
                ElseIf Allowance = "Spouse" Then
                    frmStudent.rdoSpouse.Checked = True
                ElseIf Allowance = "Self-supporting/working students" Then
                    frmStudent.rdoSelfSupporting.Checked = True
                ElseIf Allowance = "Scholarship" Then
                    frmStudent.rdoScholarship.Checked = True
                ElseIf Allowance = "Relatives" Then
                    frmStudent.rdoRelatives.Checked = True
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Function UpdateStudent() As Boolean
        Try
            sql = "Update `tblstudent` SET " &
                          "`FirstName`='" & FirstName & "', `MiddleName`='" & MiddleName & "', `LastName`='" & LastName & "', `Sex`='" & Sex & "', `CivilStatus`='" & CivilStatus & "', `DateofBirth`='" & DateofBirth & "', `Age`='" & Age & "', `PlaceofBirth`='" & PlaceofBirth & "', `CityAddress`='" & CityAddress & "', `ProvincialAddress`='" & ProvincialAddress & "', `EmailAddress`='" & EmailAddress & "', `TelephoneNo`='" & TelephoneNo & "', `MobileNo`='" & MobileNo & "', `CourseID`='" & CourseID & "', `S_Level`='" & S_Level & "', `S_Section`='" & S_Section & "', `S_Height`='" & S_Height & "', `S_Weight`='" & S_Weight & "', `Comlexion`='" & Comlexion & "', `Religion`='" & Religion & "', `HighSchoolAve`='" & HighSchoolAve & "', `Employer`='" & Employer & "', `PersontobeContact`='" & PersontobeContact & "', `P_Address`='" & P_Address & "', `P_Relationship`='" & P_Relationship & "', `P_ContactNo`='" & P_ContactNo & "' WHERE StudentID = '" & StudentID & "'"
            result = updates(sql)

            sql = "Update `tblfamilybackground` Set " &
            "`Father`='" & Father & "', `F_Age`='" & F_Age & "', `F_EducationaAttainment`='" & F_EducationaAttainment & "', `F_Occupation`='" & F_Occupation & "', `F_EmployerName`='" & F_EmployerName & "', `F_EmployerAddress`='" & F_EmployerAddress & "',`F_Living`='" & F_Living & "', `Mother`='" & Mother & "', `M_Age`='" & M_Age & "', `M_Living`='" & M_Living & "', `M_EducationaAttainment`='" & M_EducationaAttainment & "', `M_Occupation`='" & M_Occupation & "', `M_EmployerName`='" & M_EmployerName & "', `M_EmployerAddress`='" & M_EmployerAddress & "', `Guardian`='" & Guardian & "', `G_Age`='" & G_Age & "', `G_Living`='" & G_Living & "', `G_EducationaAttainment`='" & G_EducationaAttainment & "', `G_Occupation`='" & G_Occupation & "', `G_EmployerName`='" & G_EmployerName & "', `G_EmployerAddress`='" & G_EmployerAddress & "', `ParentsMartialReationship`='" & ParentsMartialReationship & "', `NoofChildren`='" & NoofChildren & "', `NoofBrothers`='" & NoofBrothers & "', `NoofSisters`='" & NoofSisters & "', `NoofSisterBrotherGainfullyEmployed`='" & NoofSisterBrotherGainfullyEmployed & "', `OrdinalPositiom`='" & OrdinalPositiom & "', `ProvidingSupport`='" & ProvidingSupport & "', `Allowance`='" & Allowance & "', `QuitePlaceStudy`='" & QuitePlaceStudy & "', `ShareRoom`='" & ShareRoom & "', `NatureofResidence`='" & NatureofResidence & "' WHERE StudentID='" & StudentID & "'"
            updates(sql)

            For Each r As DataGridViewRow In frmStudent.dtglist_EducBackground.Rows
                sql = "UPDATE `tbleducationalbackground` SET `SCHOOLGRADUATED`='" & r.Cells(1).FormattedValue & "', `SCHOOLADDRESS`='" & r.Cells(2).FormattedValue &
                "', `PUBLICPRIVATE`='" & r.Cells(3).FormattedValue & "', `DATESOFATTENDANCE`='" & r.Cells(4).FormattedValue &
                "', `HONORSRECEIVED`='" & r.Cells(4).FormattedValue & "' WHERE EDUCID=" & r.Cells(6).FormattedValue
                updates(sql)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return True
    End Function
    Public Function SaveStudents() As Boolean
        Try
            sql = "INSERT INTO `tblstudent`  " &
                           "(`StudentID`, `FirstName`, `MiddleName`, `LastName`, `Sex`, `CivilStatus`, `DateofBirth`, `Age`, `PlaceofBirth`, `CityAddress`, `ProvincialAddress`, `EmailAddress`, `TelephoneNo`, `MobileNo`, `CourseID`, `S_Level`, `S_Section`, `S_Height`, `S_Weight`, `Comlexion`, `Religion`, `HighSchoolAve`, `Employer`, `PersontobeContact`, `P_Address`, `P_Relationship`, `P_ContactNo`) VALUES " &
                           "('" & StudentID & "','" & FirstName & "','" & MiddleName & "','" & LastName & "','" & Sex & "','" & CivilStatus & "','" & DateofBirth & "','" & Age & "','" & PlaceofBirth & "','" & CityAddress & "','" & ProvincialAddress & "','" & EmailAddress & "','" & TelephoneNo & "','" & MobileNo & "','" & CourseID & "','" & S_Level & "', '" & S_Section & "','" & S_Height & "', '" & S_Weight & "','" & Comlexion & "','" & Religion & "','" & HighSchoolAve & "','" & Employer & "','" & PersontobeContact & "','" & P_Address & "','" & P_Relationship & "','" & P_ContactNo & "')"
            result = create(sql)


            sql = "INSERT INTO `tblfamilybackground` " &
            "(`StudentID`, `Father`, `F_Age`, `F_EducationaAttainment`, `F_Occupation`, `F_EmployerName`, `F_EmployerAddress`,`F_Living`, `Mother`, `M_Age`, `M_Living`, `M_EducationaAttainment`, `M_Occupation`, `M_EmployerName`, `M_EmployerAddress`, `Guardian`, `G_Age`, `G_Living`, `G_EducationaAttainment`, `G_Occupation`, `G_EmployerName`, `G_EmployerAddress`, `ParentsMartialReationship`, `NoofChildren`, `NoofBrothers`, `NoofSisters`, `NoofSisterBrotherGainfullyEmployed`, `OrdinalPositiom`, `ProvidingSupport`, `Allowance`, `QuitePlaceStudy`, `ShareRoom`, `NatureofResidence`) VALUES " &
            "('" & StudentID & "','" & Father & "', '" & F_Age & "','" & F_EducationaAttainment & "','" & F_Occupation & "','" & F_EmployerName & "','" & F_EmployerAddress & "','" & F_Living & "','" & Mother & "','" & M_Age & "','" & M_Living & "','" & M_EducationaAttainment & "','" & M_Occupation & "','" & M_EmployerName & "','" & M_EmployerAddress & "','" & Guardian & "','" & G_Age & "','" & G_Living & "','" & G_EducationaAttainment & "','" & G_Occupation & "','" & G_EmployerName & "','" & G_EmployerAddress & "','" & ParentsMartialReationship & "', '" & NoofChildren & "','" & NoofBrothers & "','" & NoofSisters & "','" & NoofSisterBrotherGainfullyEmployed & "','" & OrdinalPositiom & "','" & ProvidingSupport & "','" & Allowance & "','" & QuitePlaceStudy & "','" & ShareRoom & "', '" & NatureofResidence & "')"
            create(sql)

            For Each r As DataGridViewRow In frmStudent.dtglist_EducBackground.Rows
                sql = "INSERT INTO `tbleducationalbackground` (`StudentID`, `LEVEL`, `SCHOOLGRADUATED`, `SCHOOLADDRESS`, `PUBLICPRIVATE`, `DATESOFATTENDANCE`, `HONORSRECEIVED`) VALUES " &
                        "('" & StudentID & "','" & r.Cells(0).FormattedValue & "','" & r.Cells(1).FormattedValue & "','" & r.Cells(2).FormattedValue & "','" & r.Cells(3).FormattedValue & "','" & r.Cells(4).FormattedValue & "','" & r.Cells(5).FormattedValue & "')"
                create(sql)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return True
    End Function
End Module
