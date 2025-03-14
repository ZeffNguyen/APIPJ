using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PJ.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNotificationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CLASSES_TEACHERS_main_teacher_Id",
                table: "CLASSES");

            migrationBuilder.DropForeignKey(
                name: "FK_NOTIFICATIONS_EVENTS_event_Id",
                table: "NOTIFICATIONS");

            migrationBuilder.DropForeignKey(
                name: "FK_SCHEDULES_CLASSES_class_Id",
                table: "SCHEDULES");

            migrationBuilder.DropForeignKey(
                name: "FK_SCHEDULES_SUBJECTS_subject_Id",
                table: "SCHEDULES");

            migrationBuilder.DropForeignKey(
                name: "FK_SCHEDULES_TEACHERS_teacher_Id",
                table: "SCHEDULES");

            migrationBuilder.DropForeignKey(
                name: "FK_STUDENTS_CLASSES_class_Id",
                table: "STUDENTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TEACHERS_SUBJECTS_subject_Id",
                table: "TEACHERS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TEACHERS",
                table: "TEACHERS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SUBJECTS",
                table: "SUBJECTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_STUDENTS",
                table: "STUDENTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SCHEDULES",
                table: "SCHEDULES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NOTIFICATIONS",
                table: "NOTIFICATIONS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GRADES",
                table: "GRADES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EVENTS",
                table: "EVENTS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CLASSES",
                table: "CLASSES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ADMIN",
                table: "ADMIN");

            migrationBuilder.RenameTable(
                name: "TEACHERS",
                newName: "teachers");

            migrationBuilder.RenameTable(
                name: "SUBJECTS",
                newName: "subjects");

            migrationBuilder.RenameTable(
                name: "STUDENTS",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "SCHEDULES",
                newName: "schedules");

            migrationBuilder.RenameTable(
                name: "NOTIFICATIONS",
                newName: "notifications");

            migrationBuilder.RenameTable(
                name: "GRADES",
                newName: "grades");

            migrationBuilder.RenameTable(
                name: "EVENTS",
                newName: "events");

            migrationBuilder.RenameTable(
                name: "CLASSES",
                newName: "classes");

            migrationBuilder.RenameTable(
                name: "ADMIN",
                newName: "admins");

            migrationBuilder.RenameColumn(
                name: "subject_Id",
                table: "teachers",
                newName: "subject_id");

            migrationBuilder.RenameColumn(
                name: "teacher_Id",
                table: "teachers",
                newName: "teacher_id");

            migrationBuilder.RenameIndex(
                name: "IX_TEACHERS_subject_Id",
                table: "teachers",
                newName: "IX_teachers_subject_id");

            migrationBuilder.RenameColumn(
                name: "subject_Id",
                table: "subjects",
                newName: "subject_id");

            migrationBuilder.RenameColumn(
                name: "class_Id",
                table: "students",
                newName: "class_id");

            migrationBuilder.RenameColumn(
                name: "student_Id",
                table: "students",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "fullname",
                table: "students",
                newName: "full_name");

            migrationBuilder.RenameIndex(
                name: "IX_STUDENTS_class_Id",
                table: "students",
                newName: "IX_students_class_id");

            migrationBuilder.RenameColumn(
                name: "teacher_Id",
                table: "schedules",
                newName: "teacher_id");

            migrationBuilder.RenameColumn(
                name: "subject_Id",
                table: "schedules",
                newName: "subject_id");

            migrationBuilder.RenameColumn(
                name: "class_Id",
                table: "schedules",
                newName: "class_id");

            migrationBuilder.RenameColumn(
                name: "schedule_Id",
                table: "schedules",
                newName: "schedule_id");

            migrationBuilder.RenameIndex(
                name: "IX_SCHEDULES_teacher_Id",
                table: "schedules",
                newName: "IX_schedules_teacher_id");

            migrationBuilder.RenameIndex(
                name: "IX_SCHEDULES_subject_Id",
                table: "schedules",
                newName: "IX_schedules_subject_id");

            migrationBuilder.RenameIndex(
                name: "IX_SCHEDULES_class_Id",
                table: "schedules",
                newName: "IX_schedules_class_id");

            migrationBuilder.RenameColumn(
                name: "event_Id",
                table: "notifications",
                newName: "event_id");

            migrationBuilder.RenameColumn(
                name: "notification_Id",
                table: "notifications",
                newName: "notification_id");

            migrationBuilder.RenameColumn(
                name: "create_at",
                table: "notifications",
                newName: "created_at");

            migrationBuilder.RenameIndex(
                name: "IX_NOTIFICATIONS_event_Id",
                table: "notifications",
                newName: "IX_notifications_event_id");

            migrationBuilder.RenameColumn(
                name: "event_Id",
                table: "events",
                newName: "event_id");

            migrationBuilder.RenameColumn(
                name: "main_teacher_Id",
                table: "classes",
                newName: "main_teacher_id");

            migrationBuilder.RenameColumn(
                name: "class_Id",
                table: "classes",
                newName: "class_id");

            migrationBuilder.RenameIndex(
                name: "IX_CLASSES_main_teacher_Id",
                table: "classes",
                newName: "IX_classes_main_teacher_id");

            migrationBuilder.RenameColumn(
                name: "PASS",
                table: "admins",
                newName: "pass");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "admins",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "admins",
                newName: "admin_id");

            migrationBuilder.AlterColumn<long>(
                name: "phone",
                table: "teachers",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "teacher_id",
                table: "teachers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "subject_name",
                table: "subjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "subject_id",
                table: "subjects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "students",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "student_id",
                table: "students",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "room",
                table: "schedules",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "detail",
                table: "schedules",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "schedule_id",
                table: "schedules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "message",
                table: "notifications",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "notification_id",
                table: "notifications",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "GradeId",
                table: "grades",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "event_id",
                table: "events",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "main_teacher_id",
                table: "classes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "class_name",
                table: "classes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "class_id",
                table: "classes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teachers",
                table: "teachers",
                column: "teacher_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subjects",
                table: "subjects",
                column: "subject_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "student_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_schedules",
                table: "schedules",
                column: "schedule_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_notifications",
                table: "notifications",
                column: "notification_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_grades",
                table: "grades",
                column: "GradeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_events",
                table: "events",
                column: "event_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_classes",
                table: "classes",
                column: "class_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admins",
                table: "admins",
                column: "admin_id");

            migrationBuilder.AddForeignKey(
                name: "FK_classes_teachers_main_teacher_id",
                table: "classes",
                column: "main_teacher_id",
                principalTable: "teachers",
                principalColumn: "teacher_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_notifications_events_event_id",
                table: "notifications",
                column: "event_id",
                principalTable: "events",
                principalColumn: "event_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_schedules_classes_class_id",
                table: "schedules",
                column: "class_id",
                principalTable: "classes",
                principalColumn: "class_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_schedules_subjects_subject_id",
                table: "schedules",
                column: "subject_id",
                principalTable: "subjects",
                principalColumn: "subject_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_schedules_teachers_teacher_id",
                table: "schedules",
                column: "teacher_id",
                principalTable: "teachers",
                principalColumn: "teacher_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_students_classes_class_id",
                table: "students",
                column: "class_id",
                principalTable: "classes",
                principalColumn: "class_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_subjects_subject_id",
                table: "teachers",
                column: "subject_id",
                principalTable: "subjects",
                principalColumn: "subject_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_classes_teachers_main_teacher_id",
                table: "classes");

            migrationBuilder.DropForeignKey(
                name: "FK_notifications_events_event_id",
                table: "notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_schedules_classes_class_id",
                table: "schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_schedules_subjects_subject_id",
                table: "schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_schedules_teachers_teacher_id",
                table: "schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_students_classes_class_id",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_subjects_subject_id",
                table: "teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teachers",
                table: "teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subjects",
                table: "subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_schedules",
                table: "schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_notifications",
                table: "notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_grades",
                table: "grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_events",
                table: "events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_classes",
                table: "classes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admins",
                table: "admins");

            migrationBuilder.RenameTable(
                name: "teachers",
                newName: "TEACHERS");

            migrationBuilder.RenameTable(
                name: "subjects",
                newName: "SUBJECTS");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "STUDENTS");

            migrationBuilder.RenameTable(
                name: "schedules",
                newName: "SCHEDULES");

            migrationBuilder.RenameTable(
                name: "notifications",
                newName: "NOTIFICATIONS");

            migrationBuilder.RenameTable(
                name: "grades",
                newName: "GRADES");

            migrationBuilder.RenameTable(
                name: "events",
                newName: "EVENTS");

            migrationBuilder.RenameTable(
                name: "classes",
                newName: "CLASSES");

            migrationBuilder.RenameTable(
                name: "admins",
                newName: "ADMIN");

            migrationBuilder.RenameColumn(
                name: "subject_id",
                table: "TEACHERS",
                newName: "subject_Id");

            migrationBuilder.RenameColumn(
                name: "teacher_id",
                table: "TEACHERS",
                newName: "teacher_Id");

            migrationBuilder.RenameIndex(
                name: "IX_teachers_subject_id",
                table: "TEACHERS",
                newName: "IX_TEACHERS_subject_Id");

            migrationBuilder.RenameColumn(
                name: "subject_id",
                table: "SUBJECTS",
                newName: "subject_Id");

            migrationBuilder.RenameColumn(
                name: "class_id",
                table: "STUDENTS",
                newName: "class_Id");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "STUDENTS",
                newName: "student_Id");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "STUDENTS",
                newName: "fullname");

            migrationBuilder.RenameIndex(
                name: "IX_students_class_id",
                table: "STUDENTS",
                newName: "IX_STUDENTS_class_Id");

            migrationBuilder.RenameColumn(
                name: "teacher_id",
                table: "SCHEDULES",
                newName: "teacher_Id");

            migrationBuilder.RenameColumn(
                name: "subject_id",
                table: "SCHEDULES",
                newName: "subject_Id");

            migrationBuilder.RenameColumn(
                name: "class_id",
                table: "SCHEDULES",
                newName: "class_Id");

            migrationBuilder.RenameColumn(
                name: "schedule_id",
                table: "SCHEDULES",
                newName: "schedule_Id");

            migrationBuilder.RenameIndex(
                name: "IX_schedules_teacher_id",
                table: "SCHEDULES",
                newName: "IX_SCHEDULES_teacher_Id");

            migrationBuilder.RenameIndex(
                name: "IX_schedules_subject_id",
                table: "SCHEDULES",
                newName: "IX_SCHEDULES_subject_Id");

            migrationBuilder.RenameIndex(
                name: "IX_schedules_class_id",
                table: "SCHEDULES",
                newName: "IX_SCHEDULES_class_Id");

            migrationBuilder.RenameColumn(
                name: "event_id",
                table: "NOTIFICATIONS",
                newName: "event_Id");

            migrationBuilder.RenameColumn(
                name: "notification_id",
                table: "NOTIFICATIONS",
                newName: "notification_Id");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "NOTIFICATIONS",
                newName: "create_at");

            migrationBuilder.RenameIndex(
                name: "IX_notifications_event_id",
                table: "NOTIFICATIONS",
                newName: "IX_NOTIFICATIONS_event_Id");

            migrationBuilder.RenameColumn(
                name: "event_id",
                table: "EVENTS",
                newName: "event_Id");

            migrationBuilder.RenameColumn(
                name: "main_teacher_id",
                table: "CLASSES",
                newName: "main_teacher_Id");

            migrationBuilder.RenameColumn(
                name: "class_id",
                table: "CLASSES",
                newName: "class_Id");

            migrationBuilder.RenameIndex(
                name: "IX_classes_main_teacher_id",
                table: "CLASSES",
                newName: "IX_CLASSES_main_teacher_Id");

            migrationBuilder.RenameColumn(
                name: "pass",
                table: "ADMIN",
                newName: "PASS");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "ADMIN",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "admin_id",
                table: "ADMIN",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "phone",
                table: "TEACHERS",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "TEACHERS",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "teacher_Id",
                table: "TEACHERS",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<string>(
                name: "subject_name",
                table: "SUBJECTS",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "subject_Id",
                table: "SUBJECTS",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<int>(
                name: "phone",
                table: "STUDENTS",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "student_Id",
                table: "STUDENTS",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<string>(
                name: "room",
                table: "SCHEDULES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "detail",
                table: "SCHEDULES",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "schedule_Id",
                table: "SCHEDULES",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<string>(
                name: "message",
                table: "NOTIFICATIONS",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<Guid>(
                name: "notification_Id",
                table: "NOTIFICATIONS",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<Guid>(
                name: "GradeId",
                table: "GRADES",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "EVENTS",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "event_Id",
                table: "EVENTS",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "gen_random_uuid()");

            migrationBuilder.AlterColumn<Guid>(
                name: "main_teacher_Id",
                table: "CLASSES",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "class_name",
                table: "CLASSES",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<Guid>(
                name: "class_Id",
                table: "CLASSES",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "gen_random_uuid()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TEACHERS",
                table: "TEACHERS",
                column: "teacher_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SUBJECTS",
                table: "SUBJECTS",
                column: "subject_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_STUDENTS",
                table: "STUDENTS",
                column: "student_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SCHEDULES",
                table: "SCHEDULES",
                column: "schedule_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NOTIFICATIONS",
                table: "NOTIFICATIONS",
                column: "notification_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GRADES",
                table: "GRADES",
                column: "GradeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EVENTS",
                table: "EVENTS",
                column: "event_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CLASSES",
                table: "CLASSES",
                column: "class_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ADMIN",
                table: "ADMIN",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CLASSES_TEACHERS_main_teacher_Id",
                table: "CLASSES",
                column: "main_teacher_Id",
                principalTable: "TEACHERS",
                principalColumn: "teacher_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NOTIFICATIONS_EVENTS_event_Id",
                table: "NOTIFICATIONS",
                column: "event_Id",
                principalTable: "EVENTS",
                principalColumn: "event_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SCHEDULES_CLASSES_class_Id",
                table: "SCHEDULES",
                column: "class_Id",
                principalTable: "CLASSES",
                principalColumn: "class_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SCHEDULES_SUBJECTS_subject_Id",
                table: "SCHEDULES",
                column: "subject_Id",
                principalTable: "SUBJECTS",
                principalColumn: "subject_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SCHEDULES_TEACHERS_teacher_Id",
                table: "SCHEDULES",
                column: "teacher_Id",
                principalTable: "TEACHERS",
                principalColumn: "teacher_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENTS_CLASSES_class_Id",
                table: "STUDENTS",
                column: "class_Id",
                principalTable: "CLASSES",
                principalColumn: "class_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TEACHERS_SUBJECTS_subject_Id",
                table: "TEACHERS",
                column: "subject_Id",
                principalTable: "SUBJECTS",
                principalColumn: "subject_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
