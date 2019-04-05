<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/LookUpEdit/MainPage.xaml) (VB: [MainPage.xaml](./VB/LookUpEdit/MainPage.xaml))
* [MainPage.xaml.cs](./CS/LookUpEdit/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/LookUpEdit/MainPage.xaml.vb))
<!-- default file list end -->
# How to use the grid control in the popup window of the LookUpEdit editor


<p>Please note that it is necessary to define the name of the grid control in the PopupContentTemplate tag as 'PART_GridControl'.  Otherwise, the editor will not find the grid control.</p><br />
<p>Here is some sample code:</p><para><code lang="xaml">                <dxg:LookUpEdit Name="editor" VerticalAlignment="Top" Width="400" DisplayMember="Name" ValueMember="ID">            <br />
            <dxg:LookUpEdit.PopupContentTemplate><br />
                <ControlTemplate><br />
                    <dxg:GridControl x:Name="PART_GridControl" AutoGenerateColumns="AddNew" VerticalAlignment="Top"><br />
                    <dxg:GridControl.View><br />
                        <dxg:TableView/><br />
                    </dxg:GridControl.View><br />
                    </dxg:GridControl><br />
                </ControlTemplate><br />
                </dxg:LookUpEdit.PopupContentTemplate><br />
        </dxg:LookUpEdit>

<br/>


