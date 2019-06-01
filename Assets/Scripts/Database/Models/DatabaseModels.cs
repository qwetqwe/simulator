/**
 * Copyright (c) 2019 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

namespace Simulator.Database
{
    public class DatabaseModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
    [PetaPoco.TableName("maps")]
    [PetaPoco.PrimaryKey("maps, id")]
    public class MapModel : DatabaseModel
    {
        public string Url { get; set; }
        public string PreviewUrl { get; set; }
        public string LocalPath { get; set; }
        public string Error { get; set; }
    }

    [PetaPoco.TableName("vehicles")]
    [PetaPoco.PrimaryKey("vehicles, id")]
    public class VehicleModel : DatabaseModel
    {
        public string Url { get; set; }
        public string PreviewUrl { get; set; }
        public string LocalPath { get; set; }
        public string Sensors { get; set; }
        public string Error { get; set; }
    }

    [PetaPoco.TableName("clusters")]
    [PetaPoco.PrimaryKey("clusters, id")]
    public class ClusterModel : DatabaseModel
    {
        public string Ips { get; set; }
    }

    [PetaPoco.TableName("simulations")]
    [PetaPoco.PrimaryKey("simulations, id")]
    public class SimulationModel : DatabaseModel
    {
        public long? Cluster { get; set; }
        public long? Map { get; set; }
        public string Vehicles { get; set; }
        public bool? ApiOnly { get; set; }
        public bool? Interactive { get; set; }
        public bool? OffScreen { get; set; }
        public System.DateTime? TimeOfDay { get; set; }
        public float? Rain { get; set; }
        public float? Fog { get; set; }
        public float? Wetness { get; set; }
        public float? Cloudiness { get; set; }
    }
}
