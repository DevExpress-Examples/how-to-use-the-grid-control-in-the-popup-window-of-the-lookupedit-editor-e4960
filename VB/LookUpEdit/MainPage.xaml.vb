Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Grid.LookUp

Namespace LookUpEditPopupContentTemplate
	Partial Public Class MainPage
		Inherits UserControl
		Private Items As New ObservableCollection(Of Item)()

		Public Sub New()
			InitializeComponent()
			AddHandler Me.Loaded, AddressOf MainPage_Loaded
		End Sub

		Private Sub MainPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)

			For i As Integer = 0 To 24
				Dim it As New Item() With {.ID = i, .Name = "Name" & i.ToString(), .ItemDate = DateTime.Now.AddDays(i)}
				Items.Add(it)
			Next i
			editor.ItemsSource = Items
			
		End Sub
	End Class

	Public Class Item
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateDate As DateTime
		Public Property ItemDate() As DateTime
			Get
				Return privateDate
			End Get
			Set(ByVal value As DateTime)
				privateDate = value
			End Set
		End Property
	End Class



End Namespace
