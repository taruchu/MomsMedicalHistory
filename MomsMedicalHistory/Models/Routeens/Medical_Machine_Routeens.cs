using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Transactions;
using System.Data.SqlClient;


namespace MomsMedicalHistory.Models
{
    public class Medical_Machine_Routeens
    {
        public static IEnumerable<allergic_medications> Read_allergic_medications(int? id = null)
        {
            IEnumerable<allergic_medications> query = null;
            using (TransactionScope tran = new TransactionScope())
            {
                try
                {
                    using(Medical_MachineEntities context = new Medical_MachineEntities())
                    {
                        
                        query = context
                            .allergic_medications
                            .ToList<allergic_medications>();
                        query = (id == null) ?
                                        query
                                        : query
                                            .Where(a => a.allergic_ID == id);                                                    
                    }
                    tran.Complete();
                    tran.Dispose();
                }
                catch(TransactionException ex)
                {
                    tran.Dispose();
                    throw new ApplicationException(ex.Message);
                }
                catch(SqlException ex)
                {
                    throw new ApplicationException(ex.Message);
                }
                return query;
            }
        }
        public static void Create_allergic_medications(allergic_medications model)
        {
            if(model != null)
                using(TransactionScope tran = new TransactionScope())
                {
                    try
                    {
                        using(Medical_MachineEntities context = new Medical_MachineEntities())
                        {
                            context.allergic_medications.Add(model);
                            context.SaveChanges(); 
                        }
                        tran.Complete();
                        tran.Dispose();
                    }
                    catch(TransactionException ex)
                    {
                        tran.Dispose();
                        throw new ApplicationException(ex.Message);
                    }
                    catch(SqlException ex)
                    { 
                        throw new ApplicationException(ex.Message);
                    }
                }
        }
        public static void Update_allergic_medications(allergic_medications model)
        {
            if(model != null)
                using(TransactionScope tran = new TransactionScope())
                {
                    try
                    {
                        using(Medical_MachineEntities context = new Medical_MachineEntities())
                        {
                            context
                              .allergic_medications
                              .ToList<allergic_medications>()
                              .Where(a => a.allergic_ID == model.allergic_ID)
                              .FirstOrDefault<allergic_medications>()
                              .allergic_name = model.allergic_name;
                            context.SaveChanges();                           
                        }
                        tran.Complete();
                        tran.Dispose();
                    }
                    catch(TransactionException ex)
                    {
                        tran.Dispose();
                        throw new ApplicationException(ex.Message);
                    }
                    catch (SqlException ex)
                    {
                        throw new ApplicationException(ex.Message);
                    }
                }
        }


        public static IEnumerable<city> Read_city(int? id = null)
        {
            IEnumerable<city> query = null;
            using (TransactionScope tran = new TransactionScope())
            {
                try
                {
                    using(Medical_MachineEntities context = new Medical_MachineEntities())
                    {
                        query = context
                            .cities
                            .ToList<city>();
                        query = (id == null) ?
                            query :
                            query
                                .Where(a => a.city_ID == id);
                    }
                    tran.Complete();
                    tran.Dispose();
                }
                catch(TransactionException ex)
                {
                    tran.Dispose();
                    throw new ApplicationException(ex.Message);
                }
            }
            return query;
        }
        public static void Create_city(city model)
        { 
            if(model != null)
                using(TransactionScope tran = new TransactionScope())
                {
                    try
                    {
                        using(Medical_MachineEntities context = new Medical_MachineEntities())
                        {
                            context.cities.Add(model);
                            context.SaveChanges();                            
                        }
                        tran.Complete();
                        tran.Dispose();
                    }
                    catch(TransactionException ex)
                    {
                        tran.Dispose();
                        throw new ApplicationException(ex.Message);
                    }
                    catch (SqlException ex)
                    {
                        throw new ApplicationException(ex.Message);
                    }
                } 
        }
        public static void Update_city(city model)
        {
            if(model != null)
                using (TransactionScope tran = new TransactionScope())
                {
                    try
                    {
                        using (Medical_MachineEntities context = new Medical_MachineEntities())
                        {
                            context
                                .cities
                                .ToList<city>()
                                .Where(a => a.city_ID == model.city_ID)
                                .FirstOrDefault<city>()
                                .city_name = model.city_name;
                            context.SaveChanges();                            
                        }
                        tran.Complete();
                        tran.Dispose();
                    }
                    catch(TransactionException ex)
                    {
                        tran.Dispose();
                        throw new ApplicationException(ex.Message);
                    }
                    catch (SqlException ex)
                    {
                        throw new ApplicationException(ex.Message);
                    }
                }
        }




    }
}