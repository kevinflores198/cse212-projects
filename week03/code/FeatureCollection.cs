
public class FeatureCollection
{
    // it will map the json data, will have a list of features which will have the earthquake properties.
        public List<Feature> Features { get; set; } = new();

}

public class Feature
{
    // properties of the earthquake, 
    // we only care about the place and magnitude
    public EarthquakeProperties Properties { get; set; } = new();
}

public class EarthquakeProperties
{
    // that is what we care about, plase and magnitude.
    public string? Place { get; set; }
    public double? Mag { get; set; }
}
