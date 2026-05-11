-- ─── Create and use the database ─────────────────────────────────────────────
CREATE DATABASE IF NOT EXISTS studentcrudb;
USE studentcrudb;

-- ─── Drop tables if they exist (clean start) ─────────────────────────────────
DROP TABLE IF EXISTS Students;
DROP TABLE IF EXISTS StudentIDCounter;

-- ─── Students table ───────────────────────────────────────────────────────────
CREATE TABLE Students (
    StudentID     VARCHAR(10)  NOT NULL PRIMARY KEY,
    FirstName     VARCHAR(50)  NOT NULL,
    LastName      VARCHAR(50)  NOT NULL,
    MiddleInitial VARCHAR(5),
    Birthdate     DATE         NOT NULL,
    Gender        VARCHAR(20),
    Address       VARCHAR(255),
    Course        VARCHAR(20),
    Year          INT,
    ImagePath     VARCHAR(500)
);

-- ─── Counter table for organized IDs (2025-0001, 2025-0002, etc.) ────────────
CREATE TABLE StudentIDCounter (
    Year       INT NOT NULL PRIMARY KEY,
    LastNumber INT NOT NULL DEFAULT 0
);

-- ─── Verify tables were created ───────────────────────────────────────────────
SHOW TABLES;
DESCRIBE Students;
DESCRIBE StudentIDCounter;