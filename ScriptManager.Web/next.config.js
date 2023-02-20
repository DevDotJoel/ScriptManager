/** @type {import('next').NextConfig} */
const nextConfig = {
  experimental: {
    reactStrictMode: true,
    appDir: true,
    serverComponentsExternalPackages: ['react-bootstrap'],  },
    fontLoaders: [
      { loader: '@next/font/google', options: { subsets: ['latin'] } },
    ],
}

module.exports = nextConfig
