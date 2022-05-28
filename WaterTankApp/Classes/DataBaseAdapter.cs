using System;
using Npgsql;

namespace WaterTankApp.Classes
{
	class DataBaseAdapter
	{
		public DataBaseAdapter(string user, string password, string database,
			string server = "127.0.0.1", int port = 5432)
		{
			this.server = server;
			this.port = port;
			this.user = user;
			this.password = password;
			this.database = database;

			try
			{
				using (NpgsqlConnection nconn = new NpgsqlConnection(Connection))
				{
					nconn.Open();

					NpgsqlCommand cmdCreate = new NpgsqlCommand("create table if not exists test1(" +
						"id int primary key," +
						"tank varchar(32) not null," +
						"ts int, volume real);", nconn);
					cmdCreate.ExecuteNonQuery();

					NpgsqlCommand cmdCount = new NpgsqlCommand("select count(id) from test1", nconn);
					NpgsqlDataReader reader = cmdCount.ExecuteReader();
					if (reader.Read())
						id = int.Parse(reader[0].ToString());
				}
			}
			catch (PostgresException) { }
			catch (Exception) { }
		}

		public void AddSimulation(WaterTankSimulation wts)
		{
			wts.PointCalculated += (t, v) =>
			{
				try
				{
					using (NpgsqlConnection nconn = new NpgsqlConnection(Connection))
					{
						nconn.Open();
						NpgsqlCommand cmd = new NpgsqlCommand(String.Format(
							"insert into test1 (id, tank, ts, volume) " +
							"values ('{0}', '{1}', '{2}', '{3}');",
							id++, wts.Tank.Name, t, v.ToString("F3").Replace(',', '.')), nconn);
						cmd.ExecuteNonQuery();
					}
				}
				catch (PostgresException) { }
				catch (Exception) { }
			};
		}

		private string Connection
		{
			get
			{
				return String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4}",
					server, port, user, password, database);
			}
		}

		private string server, user, password, database;
		private int port;
		private int id = 0;
	}
}
