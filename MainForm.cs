using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

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

        // Load entities into the change tracker so Local contains the rows from the DB
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

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        // Validate input fields
        var vin = textBoxVIN.Text?.Trim();
        var make = textBoxMake.Text?.Trim();
        var model = textBoxModel.Text?.Trim();
        var yearText = textBoxYear.Text?.Trim();

        if (string.IsNullOrEmpty(vin) || string.IsNullOrEmpty(make) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(yearText))
        {
            MessageBox.Show("Please fill in VIN, Make, Model and Year before adding.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!int.TryParse(yearText, out var year))
        {
            MessageBox.Show("Year must be a valid integer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var car = new Car
        {
            VIN = vin,
            Make = make,
            Model = model,
            Year = year
        };

        myDb.Cars.Add(car);
        myDb.SaveChanges();

        // Clear input fields
        textBoxVIN.Clear();
        textBoxMake.Clear();
        textBoxModel.Clear();
        textBoxYear.Clear();

        // Ensure grid refresh / selection
        this.dataGridViewCars.Refresh();
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        var current = this.carBindingSource.Current as Car;
        if (current == null)
        {
            MessageBox.Show("Select a row to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return; // nothing selected
        }

        // Remove from context and persist
        myDb.Cars.Remove(current);
        myDb.SaveChanges();

        this.dataGridViewCars.Refresh();
    }
}
