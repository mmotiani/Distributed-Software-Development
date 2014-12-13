<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h1>
          <center>List of Users</center>
        </h1>
        <table border="1" align="center">
          <tr bgcolor="blue" style="font-size:20pt; font-family:times new roman;">
            <td  align="center">
              <b>Username</b>
            </td>
            <td align="center">
              <b>First Name</b>
            </td>
            <td  align="center">
              <b>Last Name</b>
            </td>
            <td  align="center">
              <b>Role</b>
            </td>
          </tr>


          <xsl:for-each select="UserInformation/information">
            <xsl:sort select="Last"/>
            <tr style="font-size:15pt; font-family:calibri">

              <td>
                <xsl:value-of select="@username"/>
              </td>

              <td>
                <xsl:value-of select="First"/>
              </td>
              <td>
                <xsl:value-of select="Last"/>
              </td>
              <td>
                <xsl:value-of select="Role"/>
              </td>


            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>