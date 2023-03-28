-- Enabling the replication database
use master
exec sp_replicationdboption @dbname = N'VGS_DRV_ERP_GLB_TES', @optname = N'publish', @value = N'true'
GO

exec [VGS_DRV_ERP_GLB_TES].sys.sp_addlogreader_agent @job_login = null, @job_password = null, @publisher_security_mode = 1
GO
-- Adding the transactional publication
use [VGS_DRV_ERP_GLB_TES]
exec sp_addpublication @publication = N'VSoft_Company_CTM_Customer_Pub', @description = N'Transactional publication of database ''VGS_DRV_ERP_GLB_TES'' from Publisher ''VPS042900''.', @sync_method = N'concurrent', @retention = 0, @allow_push = N'true', @allow_pull = N'true', @allow_anonymous = N'true', @enabled_for_internet = N'false', @snapshot_in_defaultfolder = N'true', @compress_snapshot = N'false', @ftp_port = 21, @ftp_login = N'anonymous', @allow_subscription_copy = N'false', @add_to_active_directory = N'false', @repl_freq = N'continuous', @status = N'active', @independent_agent = N'true', @immediate_sync = N'true', @allow_sync_tran = N'false', @autogen_sync_procs = N'false', @allow_queued_tran = N'false', @allow_dts = N'false', @replicate_ddl = 1, @allow_initialize_from_backup = N'false', @enabled_for_p2p = N'false', @enabled_for_het_sub = N'false'
GO


exec sp_addpublication_snapshot @publication = N'VSoft_Company_CTM_Customer_Pub', @frequency_type = 1, @frequency_interval = 0, @frequency_relative_interval = 0, @frequency_recurrence_factor = 0, @frequency_subday = 0, @frequency_subday_interval = 0, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @job_login = null, @job_password = null, @publisher_security_mode = 1
exec sp_grant_publication_Customeress @publication = N'VSoft_Company_CTM_Customer_Pub', @login = N'sa'
GO
exec sp_grant_publication_Customeress @publication = N'VSoft_Company_CTM_Customer_Pub', @login = N'VPS042900\Administrator'
GO
exec sp_grant_publication_Customeress @publication = N'VSoft_Company_CTM_Customer_Pub', @login = N'NT SERVICE\Winmgmt'
GO
exec sp_grant_publication_Customeress @publication = N'VSoft_Company_CTM_Customer_Pub', @login = N'NT SERVICE\SQLWriter'
GO
exec sp_grant_publication_Customeress @publication = N'VSoft_Company_CTM_Customer_Pub', @login = N'NT SERVICE\SQLSERVERAGENT'
GO
--exec sp_grant_publication_Customeress @publication = N'VSoft_Company_CTM_Customer_Pub', @login = N'NT Service\MSSQLSERVER'
--GO
--exec sp_grant_publication_Customeress @publication = N'VSoft_Company_CTM_Customer_Pub', @login = N'l_certSignSmDetach'
--GO
exec sp_grant_publication_Customeress @publication = N'VSoft_Company_CTM_Customer_Pub', @login = N'distributor_admin'
GO
exec sp_grant_publication_Customeress @publication = N'VSoft_Company_CTM_Customer_Pub', @login = N'drv_apps_2023'
GO

-- Adding the transactional articles
use [VGS_DRV_ERP_GLB_TES]
exec sp_addarticle @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @source_owner = N'dbo', @source_object = N'QTHT_Taikhoan', @type = N'logbased', @description = N'', @creation_script = N'', @pre_creation_cmd = N'drop', @schema_option = 0x000000000803509F, @identityrangemanagementoption = N'manual', @destination_table = N'QTHT_Taikhoan', @destination_owner = N'dbo', @status = 24, @vertical_partition = N'true', @ins_cmd = N'CALL [sp_MSins_dboQTHT_Taikhoan]', @del_cmd = N'CALL [sp_MSdel_dboQTHT_Taikhoan]', @upd_cmd = N'SCALL [sp_MSupd_dboQTHT_Taikhoan]'

-- Adding the article's partition column(s)
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'CTMname', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'Manhanvien', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'Password', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'Hoten', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'Dienthoai', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'Email', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'NgaythangNS', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'SudungPM', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'Sudung', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'Id_Nhomnguoidung', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'Ten_Nhomnguoidung', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'Id_DMCoso', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
exec sp_articlecolumn @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @column = N'EmployeeId', @operation = N'add', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1

-- Adding the article synchronization object
exec sp_articleview @publication = N'VSoft_Company_CTM_Customer_Pub', @article = N'VSoft_Company_CTM_Customer_Tbl', @view_name = N'SYNC_VSoft_Company_CTM_Customer_Tbl', @filter_clause = N'', @force_invalidate_snapshot = 1, @force_reinit_subscription = 1
GO

-- Adding the transactional subscriptions
use [VGS_DRV_ERP_GLB_TES]
exec sp_addsubscription @publication = N'VSoft_Company_CTM_Customer_Pub', @subscriber = N'VPS042900', @destination_db = N'VSOFT_COM_TEST', @subscription_type = N'Push', @sync_type = N'automatic', @article = N'all', @update_mode = N'read only', @subscriber_type = 0
exec sp_addpushsubscription_agent @publication = N'VSoft_Company_CTM_Customer_Pub', @subscriber = N'VPS042900', @subscriber_db = N'VSOFT_COM_TEST', @job_login = null, @job_password = null, @subscriber_security_mode = 1, @frequency_type = 64, @frequency_interval = 1, @frequency_relative_interval = 1, @frequency_recurrence_factor = 0, @frequency_subday = 4, @frequency_subday_interval = 5, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @dts_package_location = N'Distributor'
GO

