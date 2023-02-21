/** @type {import('next').NextConfig} */
const nextConfig = {
  output:"standalone",
  reactStrictMode: true,
  experimental: {
    appDir: true,
    serverComponentsExternalPackages: ['react-bootstrap'],  },
    fontLoaders: [
      { loader: '@next/font/google', options: { subsets: ['latin'] } },
    ],
}

module.exports = nextConfig
