/** @type {import('next').NextConfig} */
const nextConfig = {
  experimental: {
    output: 'standalone',
    appDir: true,
    serverComponentsExternalPackages: ['react-bootstrap'],  },
    fontLoaders: [
      { loader: '@next/font/google', options: { subsets: ['latin'] } },
    ],
}

module.exports = nextConfig
