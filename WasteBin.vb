
Namespace DLAFormfactory

    Public Class WasteBin
        Public Shared Function WasteBinElement(Repository As EA.Repository, strEntityId As String) As Boolean
            Dim oElement As EA.Element
            Dim intPackage_id As Int32 = GetWasteBinPackage_id()
            Try
                If intPackage_id <> -999 Then
                    oElement = Repository.GetElementByID(Convert.ToInt32(strEntityId))
                    If oElement.PackageID <> intPackage_id Then
                        Dim oClone = oElement.Clone()
                        oClone.PackageID = intPackage_id
                        oClone.Name = oElement.Name + " (Del)"
                        oClone.Status = "Deleted"
                        oClone.Update()
                        Return True
                    Else
                        Return DeleteFromWasteBin(Repository)
                    End If
                Else
                    Return True
                End If
                Return True
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return False
        End Function
        Private Shared Function DeleteFromWasteBin(Repository As EA.Repository) As Boolean
            If Repository.IsSecurityEnabled = False Or DLA2EAHelper.IsUserGroupMember(Repository, "Administrators") Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Shared Function WasteBinPackage(Repository As EA.Repository, strEntityId As String) As Boolean
            Dim oPackage As EA.Package
            Dim intPackage_id As Int32 = GetWasteBinPackage_id()

            Try
                If intPackage_id <> -999 Then
                    oPackage = Repository.GetPackageByID(Convert.ToInt32(strEntityId))
                    If oPackage.ParentID <> intPackage_id Then
                        Dim oClone As EA.Package
                        oClone = oPackage.Clone
                        oClone.ParentID = intPackage_id
                        oClone.Name = oPackage.Name + " (Del)"
                        oClone.Update()
                        Return True
                    Else
                        Return DeleteFromWasteBin(Repository)
                    End If
                End If
                Return True
            Catch ex As Exception
                DLA2EAHelper.Error2Log(ex)
            End Try
            Return False
        End Function
        Shared Function GetWasteBinPackage_id() As Int32
            Dim oDef As New IDEADefinitions()
            Dim strPackage_id As String
            Dim intPackage_id As Int32 = -999
            strPackage_id = oDef.GetSettingValue("WasteBinPackage_id")
            If strPackage_id.Length > 0 And strPackage_id <> "-999" Then
                intPackage_id = Convert.ToInt32(strPackage_id)
            End If
            Return intPackage_id
        End Function
    End Class

End Namespace
