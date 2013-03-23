


  
using System;
using SubSonic;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace SoundCloud.DataAccess{
	internal partial class SoundCloudDB{

		public StoredProcedure CreateSong(string Title,string ArtistName,string Genre,string AlbumName,int? Year,string FileName){
			StoredProcedure sp=new StoredProcedure("CreateSong",this.Provider);
			sp.Command.AddParameter("Title",Title,DbType.AnsiString,ParameterDirection.Input);
			sp.Command.AddParameter("ArtistName",ArtistName,DbType.AnsiString,ParameterDirection.Input);
			sp.Command.AddParameter("Genre",Genre,DbType.AnsiString,ParameterDirection.Input);
			sp.Command.AddParameter("AlbumName",AlbumName,DbType.AnsiString,ParameterDirection.Input);
			sp.Command.AddParameter("Year",Year,DbType.Int32,ParameterDirection.Input);
			sp.Command.AddParameter("FileName",FileName,DbType.AnsiString,ParameterDirection.Input);
			return sp;
		}
		public StoredProcedure GetSong(int? ID){
			StoredProcedure sp=new StoredProcedure("GetSong",this.Provider);
			sp.Command.AddParameter("ID",ID,DbType.Int32,ParameterDirection.Input);
			return sp;
		}
		public StoredProcedure GetSongs(){
			StoredProcedure sp=new StoredProcedure("GetSongs",this.Provider);
			return sp;
		}
		public StoredProcedure GetTop5(){
			StoredProcedure sp=new StoredProcedure("GetTop5",this.Provider);
			return sp;
		}
		public StoredProcedure UpdateSong(int? ID,string Title,string ArtistName,string Genre,string AlbumName,int? Year,string FileName){
			StoredProcedure sp=new StoredProcedure("UpdateSong",this.Provider);
			sp.Command.AddParameter("ID",ID,DbType.Int32,ParameterDirection.Input);
			sp.Command.AddParameter("Title",Title,DbType.AnsiString,ParameterDirection.Input);
			sp.Command.AddParameter("ArtistName",ArtistName,DbType.AnsiString,ParameterDirection.Input);
			sp.Command.AddParameter("Genre",Genre,DbType.AnsiString,ParameterDirection.Input);
			sp.Command.AddParameter("AlbumName",AlbumName,DbType.AnsiString,ParameterDirection.Input);
			sp.Command.AddParameter("Year",Year,DbType.Int32,ParameterDirection.Input);
			sp.Command.AddParameter("FileName",FileName,DbType.AnsiString,ParameterDirection.Input);
			return sp;
		}
	}
}
 