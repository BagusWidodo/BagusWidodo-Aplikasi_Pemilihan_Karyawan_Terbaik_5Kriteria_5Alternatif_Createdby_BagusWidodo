-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 03 Jul 2021 pada 16.40
-- Versi server: 10.4.17-MariaDB
-- Versi PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `saw_karyawanterbaik`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `alternatif`
--

CREATE TABLE `alternatif` (
  `id_alternatif` int(11) NOT NULL,
  `nama_alternatif` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `alter_kriteria`
--

CREATE TABLE `alter_kriteria` (
  `id_ak` int(11) NOT NULL,
  `id_alternatif` int(11) NOT NULL,
  `c1` double NOT NULL,
  `c2` double NOT NULL,
  `c3` double NOT NULL,
  `c4` double NOT NULL,
  `c5` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `bobot_kriteria`
--

CREATE TABLE `bobot_kriteria` (
  `id_kriteria` int(11) NOT NULL,
  `nama_kriteria` varchar(25) NOT NULL,
  `bobot` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `bobot_preferensi`
--

CREATE TABLE `bobot_preferensi` (
  `id_preferensi` int(11) NOT NULL,
  `id_alternatif` int(11) NOT NULL,
  `nilai` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `judul_penilaian`
--

CREATE TABLE `judul_penilaian` (
  `id_judul` int(11) NOT NULL,
  `judul_penilaian` varchar(100) NOT NULL,
  `c1` varchar(25) NOT NULL,
  `c2` varchar(25) NOT NULL,
  `c3` varchar(25) NOT NULL,
  `c4` varchar(25) NOT NULL,
  `c5` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `matriks_normalisasi`
--

CREATE TABLE `matriks_normalisasi` (
  `id_matrik` int(11) NOT NULL,
  `id_alternatif` int(11) NOT NULL,
  `matriks_c1` double NOT NULL,
  `matriks_c2` double NOT NULL,
  `matriks_c3` double NOT NULL,
  `matriks_c4` double NOT NULL,
  `matriks_c5` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `nilai_pembanding`
--

CREATE TABLE `nilai_pembanding` (
  `id_pembanding` int(11) NOT NULL,
  `c1` int(1) NOT NULL,
  `c2` int(1) NOT NULL,
  `c3` int(1) NOT NULL,
  `c4` int(1) NOT NULL,
  `c5` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `alternatif`
--
ALTER TABLE `alternatif`
  ADD PRIMARY KEY (`id_alternatif`);

--
-- Indeks untuk tabel `alter_kriteria`
--
ALTER TABLE `alter_kriteria`
  ADD PRIMARY KEY (`id_ak`);

--
-- Indeks untuk tabel `bobot_kriteria`
--
ALTER TABLE `bobot_kriteria`
  ADD PRIMARY KEY (`id_kriteria`);

--
-- Indeks untuk tabel `bobot_preferensi`
--
ALTER TABLE `bobot_preferensi`
  ADD PRIMARY KEY (`id_preferensi`);

--
-- Indeks untuk tabel `judul_penilaian`
--
ALTER TABLE `judul_penilaian`
  ADD PRIMARY KEY (`id_judul`);

--
-- Indeks untuk tabel `matriks_normalisasi`
--
ALTER TABLE `matriks_normalisasi`
  ADD PRIMARY KEY (`id_matrik`);

--
-- Indeks untuk tabel `nilai_pembanding`
--
ALTER TABLE `nilai_pembanding`
  ADD PRIMARY KEY (`id_pembanding`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `alternatif`
--
ALTER TABLE `alternatif`
  MODIFY `id_alternatif` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `alter_kriteria`
--
ALTER TABLE `alter_kriteria`
  MODIFY `id_ak` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `bobot_kriteria`
--
ALTER TABLE `bobot_kriteria`
  MODIFY `id_kriteria` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `bobot_preferensi`
--
ALTER TABLE `bobot_preferensi`
  MODIFY `id_preferensi` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `judul_penilaian`
--
ALTER TABLE `judul_penilaian`
  MODIFY `id_judul` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `matriks_normalisasi`
--
ALTER TABLE `matriks_normalisasi`
  MODIFY `id_matrik` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `nilai_pembanding`
--
ALTER TABLE `nilai_pembanding`
  MODIFY `id_pembanding` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
