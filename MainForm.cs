using System.ComponentModel;

namespace Assignment_10_3_winforms_sqllite;

public partial class MainForm : Form
{
    CarContext myDb; // does not create the database - sets up the variable to hold the db
    BindingList<Car> carListBinding = new();
    
    public MainForm()
    {
        InitializeComponent();


    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        myDb = new CarContext();

        // Uncomment the line below to start fresh with a new database.
        // this.dbContext.Database.EnsureDeleted();
        myDb.Database.EnsureCreated();

        myDb.Cars.Load();

        this.carBindingSource.DataSource = myDb.Cars.Local.ToBindingList();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);

        myDb?.Dispose();
        myDb = null;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        myDb!.SaveChanges();

        this.dataGridViewCars.Refresh();
    }
}
